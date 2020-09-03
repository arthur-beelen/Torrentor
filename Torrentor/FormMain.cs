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
    public partial class FormMain : Form
    {
        //API callers
        private OMDbCaller omdbCaller;
        private YtsCaller ytsCaller;

        public FormMain()
        {
            InitializeComponent();
            omdbCaller = new OMDbCaller();
            ytsCaller = new YtsCaller();
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
            updateProgress(10, "Looking up movie with OMDb API.");

            omdbCaller.search(textBox1.Text);

            updateProgress(40, "Lookup successful. Updating UI.");

            showData();

            updateProgress(10, "UI updated. Calling YTS API.");

            //Use imdbID to search for movie to avoid movies with similar names
            ytsCaller.search(omdbCaller.result["imdbID"]);

            updateProgress(40, "YTS API called successfully.");
        }

        private void updateProgress(int increment, string message)
        {
            progressBar1.Increment(increment);
            statusLabel.Text = message;
        }

        //Add all data from Dictionary result to the form components
        private void showData()
        {
            foreach (KeyValuePair<string, string> kvp in omdbCaller.result)
            {
                richTextBox1.Text += kvp.Key + ": " + kvp.Value + "\n";
            }

            searchTitle.Text = omdbCaller.result["Title"];
            searchScore.Text = omdbCaller.result["imdbRating"];
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

        //Download poster and display it using a PictureBox
        private void displayPoster()
        {
            string posterUrl = omdbCaller.result["Poster"];
            using (var webClient = new System.Net.WebClient())
            {
                //TO DO: find better way to temporarily save the picture
                webClient.DownloadFile(posterUrl, "temp.jpg");
            }

            Bitmap bm = new Bitmap("temp.jpg");
            pictureBox2.Image = bm;
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
