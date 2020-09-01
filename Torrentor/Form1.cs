using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Torrentor
{
    public partial class Form1 : Form
    {
        private ApiCaller ac;

        public Form1()
        {
            InitializeComponent();
            ac = new ApiCaller();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {   
            callApi();
        }


        private void callApi()
        {
            ac.search(textBox1.Text);
            showData();
            
        }

        //Add all data from Dictionary result to the form components
        private void showData()
        {
            foreach (KeyValuePair<string, string> kvp in ac.result)
            {
                richTextBox1.Text += kvp.Key + ": " + kvp.Value + "\n";
            }

            searchTitle.Text = ac.result["Title"];
            searchScore.Text = ac.result["imdbRating"];
            displayPoster();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                callApi();
                
            }

            
        }

        private void displayPoster()
        {
            string posterUrl = ac.result["Poster"];
            using (var webClient = new System.Net.WebClient())
            {
                webClient.DownloadFile(posterUrl, "temp.jpg");
                // Now parse with JSON.Net
            }

            Bitmap bm = new Bitmap("temp.jpg");
            pictureBox2.Image = bm;
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;

        }
    }
}
