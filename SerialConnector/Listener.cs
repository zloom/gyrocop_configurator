using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq;
using System.Threading.Tasks;

namespace SerialConnector
{
    public class Listener
    {
        private readonly string _portName;
        private readonly int _speed;
        private SerialPort _port;

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

        public Task StartAsync()
        {
            return Task.Run(() => Start());
        }

        public void Stop()
        {
            _port.Close();
            _port.Dispose();
        }

        public void Write(string input)
        {
            _port.WriteLine(input);
        }

        private void DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            var line = _port.ReadLine().Replace("\r", "");            
            OnDataReceivedString?.Invoke(line);
        }
    }
}
