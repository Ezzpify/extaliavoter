using System;
using System.Windows.Forms;
using System.Net.Http;
using System.Collections.Generic;

namespace ExtaliaMSVoter
{

    /// <summary>
    /// Fuck Jafel
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// General variables
        /// </summary>
        private bool bEnabled;


        /// <summary>
        /// Class constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Async post to vote on the website
        /// </summary>
        /// <param name="site">Site to vote on</param>
        private async void Vote(string site)
        {
            using (var client = new HttpClient())
            {
                var values = new Dictionary<string, string>
                {
                    { "account", txt_Username.Text },
                    { "toplist", site }
                };

                var content = new FormUrlEncodedContent(values);
                var response = await client.PostAsync("http://extalia.net/vote?true", content);
            }
        }


        /// <summary>
        /// Start/Stop button
        /// This will start or stop the voting process
        /// </summary>
        private void btn_Start_Click(object sender, EventArgs e)
        {
            /*Username box is empty*/
            if (txt_Username.Text.Length == 0)
            {
                MessageBox.Show("Please enter your username.", "Error");
                txt_Username.Focus(); return;
            }

            /*Set messy variables*/
            bEnabled = !bEnabled;
            if (bEnabled)
            {
                /*Force a tick if the timer is turned on*/
                ProcessTick();
            }

            /*Enable timer and update ui*/
            timer_Vote.Enabled      = bEnabled;
            txt_Username.ReadOnly   = bEnabled;
            btn_Start.Text          = bEnabled ? "Stop" : "Start";
        }


        /// <summary>
        /// Main timer event
        /// </summary>
        private void timer_Vote_Tick(object sender, EventArgs e)
        {
            ProcessTick();
        }


        /// <summary>
        /// Calls the vote to the website
        /// </summary>
        private void ProcessTick()
        {
            /*Set last date voted*/
            dateLabel.Text = string.Format("{0} ({1})", DateTime.Now.ToLongTimeString(), DateTime.Now.ToShortDateString());

            /*Vote*/
            if (cb_Ultimate.Checked) { Vote("ultimate"); }
            if (cb_Xtreme.Checked) { Vote("xtreme"); }
        }
    }
}
