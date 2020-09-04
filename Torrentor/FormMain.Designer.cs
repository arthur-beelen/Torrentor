namespace Torrentor
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.advancedSearch = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchTitle = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2160p = new System.Windows.Forms.Button();
            this.button1080p = new System.Windows.Forms.Button();
            this.button720p = new System.Windows.Forms.Button();
            this.searchScore = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.statusLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.advancedSearch);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 27);
            this.panel1.TabIndex = 0;
            // 
            // advancedSearch
            // 
            this.advancedSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.advancedSearch.AutoSize = true;
            this.advancedSearch.Location = new System.Drawing.Point(676, 6);
            this.advancedSearch.Name = "advancedSearch";
            this.advancedSearch.Size = new System.Drawing.Size(93, 13);
            this.advancedSearch.TabIndex = 1;
            this.advancedSearch.TabStop = true;
            this.advancedSearch.Text = "Advanced Search";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(311, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.CausesValidation = false;
            this.textBox1.Location = new System.Drawing.Point(50, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Search";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // searchTitle
            // 
            this.searchTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTitle.AutoSize = true;
            this.searchTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTitle.Location = new System.Drawing.Point(3, 3);
            this.searchTitle.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.searchTitle.Name = "searchTitle";
            this.searchTitle.Size = new System.Drawing.Size(53, 25);
            this.searchTitle.TabIndex = 0;
            this.searchTitle.Text = "Title";
            this.searchTitle.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(6, 198);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(442, 261);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.Location = new System.Drawing.Point(12, 33);
            this.pictureBox2.MaximumSize = new System.Drawing.Size(300, 1080);
            this.pictureBox2.MinimumSize = new System.Drawing.Size(300, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 526);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.button2160p);
            this.panel2.Controls.Add(this.button1080p);
            this.panel2.Controls.Add(this.button720p);
            this.panel2.Controls.Add(this.searchScore);
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Controls.Add(this.searchTitle);
            this.panel2.Location = new System.Drawing.Point(318, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(451, 491);
            this.panel2.TabIndex = 3;
            // 
            // button2160p
            // 
            this.button2160p.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2160p.Enabled = false;
            this.button2160p.Location = new System.Drawing.Point(373, 465);
            this.button2160p.Name = "button2160p";
            this.button2160p.Size = new System.Drawing.Size(75, 23);
            this.button2160p.TabIndex = 5;
            this.button2160p.Text = "2160P";
            this.button2160p.UseVisualStyleBackColor = true;
            this.button2160p.Click += new System.EventHandler(this.button2160p_Click);
            // 
            // button1080p
            // 
            this.button1080p.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1080p.Enabled = false;
            this.button1080p.Location = new System.Drawing.Point(292, 465);
            this.button1080p.Name = "button1080p";
            this.button1080p.Size = new System.Drawing.Size(75, 23);
            this.button1080p.TabIndex = 4;
            this.button1080p.Text = "1080P";
            this.button1080p.UseVisualStyleBackColor = true;
            this.button1080p.Click += new System.EventHandler(this.button1080p_Click);
            // 
            // button720p
            // 
            this.button720p.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button720p.Enabled = false;
            this.button720p.Location = new System.Drawing.Point(211, 465);
            this.button720p.Name = "button720p";
            this.button720p.Size = new System.Drawing.Size(75, 23);
            this.button720p.TabIndex = 3;
            this.button720p.Text = "720P";
            this.button720p.UseVisualStyleBackColor = true;
            this.button720p.Click += new System.EventHandler(this.button720p_Click);
            // 
            // searchScore
            // 
            this.searchScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchScore.AutoSize = true;
            this.searchScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchScore.Location = new System.Drawing.Point(370, 3);
            this.searchScore.Margin = new System.Windows.Forms.Padding(3);
            this.searchScore.Name = "searchScore";
            this.searchScore.Size = new System.Drawing.Size(78, 25);
            this.searchScore.TabIndex = 2;
            this.searchScore.Text = "0.0/10";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(318, 546);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(451, 10);
            this.progressBar1.TabIndex = 4;
            // 
            // statusLabel
            // 
            this.statusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(318, 527);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(451, 16);
            this.statusLabel.TabIndex = 3;
            this.statusLabel.Text = "Idle.";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 571);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FormMain";
            this.Text = "Torrentor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label searchTitle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel advancedSearch;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label searchScore;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button button2160p;
        private System.Windows.Forms.Button button1080p;
        private System.Windows.Forms.Button button720p;
    }
}

