using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anti_AFK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int randomTime = Convert.ToInt32(randomIntervalTextBox.Text) * 1000;
            timer1.Interval = (Convert.ToInt32(intervalTextBox.Text) * 1000) + rnd.Next(randomTime * -1, randomTime);
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Keyboard keyBoard = new Keyboard();
            Random random = new Random();
            ushort wScan = 0;
            int a = random.Next(1, 4);
            switch (a)
            {
                case 1:
                    wScan = Convert.ToUInt16(key1TextBox.Text);
                    break;
                case 2:
                    wScan = Convert.ToUInt16(key2TextBox.Text);
                    break;
                case 3:
                    wScan = Convert.ToUInt16(key3TextBox.Text);
                    break;
                case 4:
                    wScan = Convert.ToUInt16(key4TextBox.Text);
                    break;
            }

            keyBoard.PressKey(wScan);
        }
    }
}
