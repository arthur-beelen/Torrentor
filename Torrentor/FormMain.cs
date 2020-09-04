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

            
            //Is a movie found by OMDb API?
            if(omdbCaller.result.Count != 0)
            {
                updateProgress(40, "Lookup successful. Updating UI.");
                showData();
                updateProgress(10, "UI updated. Calling YTS API.");
                Console.WriteLine("Number of key pairs: {0}\nimdbID: {1}", omdbCaller.result.Count, omdbCaller.result["imdbID"]);
                //Use imdbID to search for movie to avoid movies with similar names
                int status = ytsCaller.search(omdbCaller.result["imdbID"]);
                if(status == 0)
                    updateProgress(40, "YTS API called successfully.");
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
    }
}
