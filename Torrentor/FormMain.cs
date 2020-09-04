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
using System.Net;
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
            resetUi();
            updateProgress(10, "Looking up movie with OMDb API.");

            omdbCaller.search(textBox1.Text);

            
            //Is a movie found by OMDb API?
            if(omdbCaller.result.Count != 0)
            {
                updateProgress(40, "Lookup successful. Updating UI.");
                showData();
                updateProgress(10, "UI updated. Calling YTS API.");
                Console.WriteLine("Number of key pairs: {0}\nimdbID: {1}", omdbCaller.result.Count, omdbCaller.result["imdbID"]);

                //Use imdbID to search for movie to avoid movies with similar names
                int status = ytsCaller.search(omdbCaller.result["imdbID"]);
                if (status == 0)
                {
                    updateProgress(40, "YTS API called successfully.");
                    if (ytsCaller.result.ContainsKey("720p"))
                    {
                        button720p.Enabled = true;
                        Console.WriteLine("720p torrent found");
                    }
                    else
                        Console.WriteLine("no 720p found");
                        
                    if (ytsCaller.result.ContainsKey("1080p"))
                        button1080p.Enabled = true;
                    if (ytsCaller.result.ContainsKey("2160p"))
                        button2160p.Enabled = true;
                }
                else
                    updateProgress(40, "YTS API failed to find a torrent.");
            }
            else
            {
                updateProgress(90, "Movie not found. Check for typos.");
            }
        }

        private void updateProgress(int increment, string message)
        {
            progressBar1.Increment(increment);
            statusLabel.Text = message;
        }

        private void resetUi()
        {
            richTextBox1.ResetText();
            button720p.Enabled = false;
            button1080p.Enabled = false;
            button2160p.Enabled = false;
        }

        //Add all data from Dictionary result to the form components
        private void showData()
        {
            if (omdbCaller.result.Count != 0) {
                foreach (KeyValuePair<string, string> kvp in omdbCaller.result)
                {
                    richTextBox1.Text += kvp.Key + ": " + kvp.Value + "\n";
                }
                searchTitle.Text = omdbCaller.result["Title"];
                searchScore.Text = omdbCaller.result["imdbRating"];
                displayPoster();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                callApi();
            }

            
        }

        //Display poster using a PictureBox
        private void displayPoster()
        {
            string posterUrl = omdbCaller.result["Poster"];
            pictureBox2.ImageLocation = posterUrl;
        }

        private void openTorrent(string quality)
        {
            string filename = String.Concat(omdbCaller.result["Title"].Replace(" ", "_"), quality, ".torrent");
            using (var client = new WebClient())
            {
                client.DownloadFile(ytsCaller.result[quality], filename);
            }
            System.Diagnostics.Process.Start(filename);
        }

        private void button720p_Click(object sender, EventArgs e)
        {
            openTorrent("720p");
        }

        private void button1080p_Click(object sender, EventArgs e)
        {
            openTorrent("1080p");
        }

        private void button2160p_Click(object sender, EventArgs e)
        {
            openTorrent("2160p");
        }
    }
}
