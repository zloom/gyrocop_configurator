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
        List<(float yaw, float pitch, float roll)> ypr;
        public Controller()
        {
            InitializeComponent();
        }

        private void Display(string input, string prefix, TextBox output)
        {
            if (!input.StartsWith(prefix))
            {
                return;
            }

            BeginInvoke((MethodInvoker)(() =>
            {
                output.Text = input.Replace(prefix, "");
            }));         
        }

        private void button1_Click(object sender, EventArgs e)
        {

            lst = new Listener("COM4", 115200);
            ypr = new List<(float yaw, float pitch, float roll)>();
            lst.OnDataReceivedString = s =>
            {
                Display(s, "$_0", yprDisplay);
                Display(s, "$_1", outDisplay);
                Display(s, "$_2", setDisplay);
                Display(s, "$_3", speedDisplay);

                BeginInvoke((MethodInvoker)(() =>
                {
                    if (s.StartsWith("MPU") && MPULog.Checked)
                    {
                        log.Items.Add(s);

                        log.SelectedIndex = log.Items.Count - 1;
                        log.SelectedIndex = -1;
                    }

                    if (s.StartsWith("READ") && READLog.Checked)
                    {
                        log.Items.Add(s);

                        log.SelectedIndex = log.Items.Count - 1;
                        log.SelectedIndex = -1;
                    }

                    if (s.StartsWith("START") && startLog.Checked)
                    {
                        log.Items.Add(s);

                        log.SelectedIndex = log.Items.Count - 1;
                        log.SelectedIndex = -1;
                    }
            
                }));
            };
            lst.StartAsync();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Send(byte.Parse(motor1.Text), byte.Parse(motor2.Text), byte.Parse(motor3.Text), byte.Parse(motor4.Text), byte.Parse(baseSpeed.Text));
        }

        private void Send(byte motor1, byte motor2, byte motor3, byte motor4, byte baseSpeed)
        {
            lst.Write(new[] {motor1, motor2, motor3, motor4, baseSpeed });
        }

        private void disconnect_Click(object sender, EventArgs e)
        {
            lst.Stop();            
        }
    }
}
