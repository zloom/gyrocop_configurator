using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace QuadroController
{
    public partial class Controller : Form
    {
        Listener lst;
        (float yaw, float pitch, float roll) yprIn;
        (float yaw, float pitch, float roll) yprOut;
        (float yaw, float pitch, float roll) yprSet;
        (int motor1, int motor2, int motor3, int motor4) motors;

        public Controller()
        {
            InitializeComponent();
        }


        private void ConnectClick(object sender, EventArgs e)
        {
            lst = new Listener("COM3", 9600);
            lst.OnPackageReceived = data =>
            {
               

                BeginInvoke((MethodInvoker)(() =>
                {
                    log.Items.Add(data);
                    log.SelectedIndex = log.Items.Count - 1;
                    log.SelectedIndex = -1;
                }));
            };
            lst.StartAsync();
            
        }

        private void Send(byte motor1, byte motor2, byte motor3, byte motor4, byte baseSpeed)
        {
           // lst.Write(new[] {motor1, motor2, motor3, motor4, baseSpeed });
        }

        private void DisconnectClick(object sender, EventArgs e)
        {
            lst.Stop();            
        }

        private void StartClick(object sender, EventArgs e)
        {
            lst.Write(57);
        }
    }
}
