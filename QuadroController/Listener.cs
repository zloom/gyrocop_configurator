using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadroController
{
    public class Listener
    {
        private readonly string _portName;
        private readonly int _speed;
        private SerialPort _port;
        private Task _task;

        public Action<short[]> OnDataReceived { private get; set; }

        public Action<string> OnDataReceivedString { private get; set; }

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

        public void Write(byte[] input)
        {
            _port.Write(new[] { input[0] }, 0, 1);
        }

        private void DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            var line = _port.ReadLine().Replace("\r", "");
            OnDataReceivedString?.Invoke(line);
        }
    }
}
