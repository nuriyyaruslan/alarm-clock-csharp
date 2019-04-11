using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm_Clock
{
    public partial class AlarmClock : Form
    {
        public AlarmClock()
        {
            InitializeComponent();
        }
        string music;
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if(open.ShowDialog()==DialogResult.OK)
            {
                music = open.FileName;
                textBox1.Text = open.SafeFileName;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            label2.Text = maskedTextBox1.Text;
            maskedTextBox1.Text = "";
            timer1.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            timer2.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.Hour.ToString("00")+":"+ DateTime.Now.Minute.ToString("00")+":"+DateTime.Now.Second.ToString("00");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(label1.Text==label2.Text)
            {
                axWindowsMediaPlayer1.URL = music;
            }
        }
    }
}



