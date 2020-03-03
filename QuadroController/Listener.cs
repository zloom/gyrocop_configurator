using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadroController
{
    public class Listener
    {
        const string _packetSeparator = "$";
        private readonly string _portName;
        private readonly int _speed;
        private string _packageBuffer;
        private SerialPort _port;
        private Task _task;

        public Action<float[][]> OnPackageReceived { private get; set; }

        public Listener(string portName, int speed)
        {
            _portName = portName;
            _speed = speed;
        }

        public void Start()
        {
            _port = new SerialPort(_portName, _speed);
            _port.Open();
            _port.DataReceived += DataReceived;
            _packageBuffer = string.Empty;

        }

        public void StartAsync()
        {
            _task = Task.Run(() => Start());
        }

        public void Stop()
        {
            _task = null;
            _port.Close();
            _port.Dispose();
        }

        public void Write(byte input)
        {
            _port.Write(new[] { input }, 0, 1);
        }

        private void ReadBuffer() 
        {
            if (!_packageBuffer.StartsWith(_packetSeparator)&&_packageBuffer.IndexOf(_packetSeparator)!=-1)
            {
                var packageStart =_packageBuffer.IndexOf(_packetSeparator);
                _packageBuffer = _packageBuffer.Remove(0, packageStart);
            }

            var nextSeparatorIndex = _packageBuffer.IndexOf(_packetSeparator, 1);
            if (nextSeparatorIndex > 1)
            {
                var package = _packageBuffer.Substring(1, nextSeparatorIndex-1);
                _packageBuffer = _packageBuffer.Remove(0, nextSeparatorIndex);

               OnPackageReceived?.Invoke(Newtonsoft.Json.JsonConvert.DeserializeObject<float[][]>(package));
            }
        }

        private void DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            var line = _port.ReadLine().Replace("\r", "");
            Trace.TraceInformation(line);
            _packageBuffer += line;
           ReadBuffer();
        }
    }
}
