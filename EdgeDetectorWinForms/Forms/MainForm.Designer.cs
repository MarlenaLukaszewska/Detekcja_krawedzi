namespace EdgeDetectorWinForms.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxImageOryginal = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonLog = new System.Windows.Forms.Button();
            this.buttonRoberts = new System.Windows.Forms.Button();
            this.buttonCanny = new System.Windows.Forms.Button();
            this.buttonPrewitt = new System.Windows.Forms.Button();
            this.buttonSobel = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBoxEdgeImage = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageOryginal)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEdgeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 370);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Obraz oryginalny";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBoxImageOryginal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 349);
            this.panel1.TabIndex = 1;
            // 
            // pictureBoxImageOryginal
            // 
            this.pictureBoxImageOryginal.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxImageOryginal.Name = "pictureBoxImageOryginal";
            this.pictureBoxImageOryginal.Size = new System.Drawing.Size(350, 349);
            this.pictureBoxImageOryginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImageOryginal.TabIndex = 0;
            this.pictureBoxImageOryginal.TabStop = false;
            this.pictureBoxImageOryginal.Click += new System.EventHandler(this.pictureBoxImageOryginal_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Location = new System.Drawing.Point(603, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(355, 367);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Obraz po wykryciu krawędzi";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.buttonLog);
            this.groupBox3.Controls.Add(this.buttonRoberts);
            this.groupBox3.Controls.Add(this.buttonCanny);
            this.groupBox3.Controls.Add(this.buttonPrewitt);
            this.groupBox3.Controls.Add(this.buttonSobel);
            this.groupBox3.Location = new System.Drawing.Point(374, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(223, 367);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detekcja krawędzi";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(29, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 45);
            this.button1.TabIndex = 10;
            this.button1.Text = "Wykonaj wszystko i zapisz";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1Click);
            // 
            // buttonLog
            // 
            this.buttonLog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLog.Location = new System.Drawing.Point(29, 242);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(158, 47);
            this.buttonLog.TabIndex = 9;
            this.buttonLog.Text = "[5] Algorytm LoG";
            this.buttonLog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLog.UseVisualStyleBackColor = true;
            this.buttonLog.Click += new System.EventHandler(this.buttonLog_Click);
            // 
            // buttonRoberts
            // 
            this.buttonRoberts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRoberts.Location = new System.Drawing.Point(29, 189);
            this.buttonRoberts.Name = "buttonRoberts";
            this.buttonRoberts.Size = new System.Drawing.Size(158, 47);
            this.buttonRoberts.TabIndex = 8;
            this.buttonRoberts.Text = "[4] Algorytm Roberts\'a";
            this.buttonRoberts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRoberts.UseVisualStyleBackColor = true;
            this.buttonRoberts.Click += new System.EventHandler(this.buttonRoberts_Click);
            // 
            // buttonCanny
            // 
            this.buttonCanny.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCanny.Location = new System.Drawing.Point(29, 136);
            this.buttonCanny.Name = "buttonCanny";
            this.buttonCanny.Size = new System.Drawing.Size(158, 47);
            this.buttonCanny.TabIndex = 7;
            this.buttonCanny.Text = "[3] Agorytm Canny\'ego ";
            this.buttonCanny.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCanny.UseVisualStyleBackColor = true;
            this.buttonCanny.Click += new System.EventHandler(this.buttonCanny_Click);
            // 
            // buttonPrewitt
            // 
            this.buttonPrewitt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPrewitt.Location = new System.Drawing.Point(29, 83);
            this.buttonPrewitt.Name = "buttonPrewitt";
            this.buttonPrewitt.Size = new System.Drawing.Size(158, 47);
            this.buttonPrewitt.TabIndex = 6;
            this.buttonPrewitt.Text = "[2] Algorytm Prewitt\'a";
            this.buttonPrewitt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPrewitt.UseVisualStyleBackColor = true;
            this.buttonPrewitt.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonSobel
            // 
            this.buttonSobel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSobel.Location = new System.Drawing.Point(29, 30);
            this.buttonSobel.Name = "buttonSobel";
            this.buttonSobel.Size = new System.Drawing.Size(158, 47);
            this.buttonSobel.TabIndex = 5;
            this.buttonSobel.Text = "[1] Algorytm Sobel\'a";
            this.buttonSobel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSobel.UseVisualStyleBackColor = true;
            this.buttonSobel.Click += new System.EventHandler(this.buttonSobel_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Image = ((System.Drawing.Image)(resources.GetObject("buttonLoad.Image")));
            this.buttonLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLoad.Location = new System.Drawing.Point(210, 400);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(158, 47);
            this.buttonLoad.TabIndex = 3;
            this.buttonLoad.Text = "Wczytaj";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave.Image")));
            this.buttonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSave.Location = new System.Drawing.Point(606, 400);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(158, 47);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Zapisz";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 397);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Dopasuj";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(93, 397);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "1:1";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(802, 400);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Dopasuj";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(883, 400);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "1:1";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.pictureBoxEdgeImage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(349, 346);
            this.panel2.TabIndex = 2;
            // 
            // pictureBoxEdgeImage
            // 
            this.pictureBoxEdgeImage.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxEdgeImage.Name = "pictureBoxEdgeImage";
            this.pictureBoxEdgeImage.Size = new System.Drawing.Size(350, 349);
            this.pictureBoxEdgeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEdgeImage.TabIndex = 0;
            this.pictureBoxEdgeImage.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(970, 459);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wykrywanie krawędzi na liściach";
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageOryginal)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEdgeImage)).EndInit();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBoxImageOryginal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonLog;
        private System.Windows.Forms.Button buttonRoberts;
        private System.Windows.Forms.Button buttonCanny;
        private System.Windows.Forms.Button buttonPrewitt;
        private System.Windows.Forms.Button buttonSobel;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBoxEdgeImage;
    }
}