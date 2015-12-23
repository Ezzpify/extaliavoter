using System;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using System.Collections.Generic;

namespace ExtaliaMSVoter
{
    public partial class Form1 : Form
    {
        public bool bEnabled = false;

        // public bool bGTop = false;
        public bool bXtreme = true;
        public bool bUltimate = true;

        public string url = "http://extalia.net/vote?true";

        public Form1()
        {
            InitializeComponent();

            recalcnx();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                checkBox1.Checked = false;

                MessageBox.Show("Gtop100 requires clearing a captcha, so we can't do that, sorry.", "nope :(");
            }

            /*bGTop = checkBox1.Checked;

            recalcnx();*/
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            bXtreme = checkBox2.Checked;

            recalcnx();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            bUltimate = checkBox3.Checked;

            recalcnx();
        }

        public void recalcnx()
        {
            int iNX = 0;
            
            /*if(bGTop)
            {
                iNX += 3;
            }*/

            if(bXtreme)
            {
                iNX += 2;
            }

            if(bUltimate)
            {
                iNX += 1;
            }

            // quality Xd
            if(iNX == 0)
            {
                label4.Text = "0";
            }

            else
            {
                label4.Text = iNX + ",000";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "<username>")
            {
                MessageBox.Show("Enter your username.", "aww");

                return;
            }

            bEnabled = !bEnabled;
            timer1.Enabled = bEnabled;

            textBox1.ReadOnly = bEnabled;

            if(bEnabled)
            {
                timer1_Tick(timer1, EventArgs.Empty);
            }

            button1.Text = (bEnabled? "Stop":"Start");
        }

        private async void vote(string site)
        {
            using(var client = new HttpClient())
            {
                var values = new Dictionary<string, string>
                    {
                       {"account", textBox1.Text},
                       {"toplist", site}
                    };

                var content = new FormUrlEncodedContent(values);

                var response = await client.PostAsync(url, content);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;

            label5.Text = (date.ToLongTimeString() + " (" + date.ToShortDateString() + ")");


            if(bXtreme)
            {
                vote("xtreme");
            }
            
            if(bUltimate)
            {
                vote("ultimate");
            }
        }
    }
}
