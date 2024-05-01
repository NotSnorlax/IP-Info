using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net.Http;

namespace IPgrab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grad();
        }
        private void grad()
        {
            panel1.Paint += (sender, e) =>
            {
                using (LinearGradientBrush brush = new LinearGradientBrush(
                    panel1.ClientRectangle,
                    Color.FromArgb(0, 192, 0),
                    Color.FromArgb(0, 130, 0),
                    LinearGradientMode.Vertical))
                {
                    e.Graphics.FillRectangle(brush, panel1.ClientRectangle); ;
                }
            };
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            label2.Text = "Connecting to: " + textBox1.Text;
            try
            {
				string url = $"https://ipinfo.io/{textBox1.Text}/json";
				using (HttpClient http = new HttpClient())
				{
					
					HttpResponseMessage message = await http.GetAsync(url);
					message.EnsureSuccessStatusCode();
					string mesData = await message.Content.ReadAsStringAsync();
					Data info = JsonConvert.DeserializeObject<Data>(mesData);
					ip.Text = info.ip;
					anycast.Text = info.anycast;
					city.Text = info.city;
					region.Text = info.region;
					country.Text = info.country;
					loc.Text = info.loc;
					org.Text = info.org;
					postal.Text = info.postal;
					timezone.Text = info.timezone;
                    readme.Text = info.readme;
				}
				label2.Text = "Grabbed: " + textBox1.Text;
                textBox1.Enabled = true;
            }
            catch
            {
                label2.Text = "Connection failed to: " + textBox1.Text;

                textBox1.Enabled = true;
            }
            textBox1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(ip.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(anycast.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(city.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(region.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(country.Text);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(loc.Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(org.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(postal.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(timezone.Text);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(readme.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText("IP: " + ip.Text + "\r\nAnycast: " + anycast.Text + "\r\nCity: " + city.Text + "\r\nRegion: " + region.Text + "\r\nCountry: " + country.Text + "\r\nLoc: " + loc.Text + "\r\nOrg: " + org.Text + "\r\nPostal: " + postal.Text + "\r\nTimezone: " + timezone.Text + "\r\nReadme:" + readme.Text);
        }

        private void Form1_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            About about = new About();
            about.Show();
        }
    }
    public class Data
    {
        public string ip { get; set; }
        public string anycast { get; set; }
        public string city { get; set; }
		public string region { get; set; }
		public string country { get; set; }
		public string loc { get; set; }
		public string org { get; set; }
		public string postal { get; set; }
		public string timezone { get; set; }
		public string readme { get; set; }
	}
}
