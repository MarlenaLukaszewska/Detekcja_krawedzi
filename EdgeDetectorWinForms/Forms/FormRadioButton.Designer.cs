namespace EdgeDetectorWinForms.Forms
{
    partial class FormRadioButton
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
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRadioButton));
        	this.buttonLoad = new System.Windows.Forms.Button();
        	this.buttonCancel = new System.Windows.Forms.Button();
        	this.radioButton1 = new System.Windows.Forms.RadioButton();
        	this.radioButton2 = new System.Windows.Forms.RadioButton();
        	this.groupBox1 = new System.Windows.Forms.GroupBox();
        	this.groupBox1.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// buttonLoad
        	// 
        	this.buttonLoad.DialogResult = System.Windows.Forms.DialogResult.OK;
        	this.buttonLoad.Image = ((System.Drawing.Image)(resources.GetObject("buttonLoad.Image")));
        	this.buttonLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
        	this.buttonLoad.Location = new System.Drawing.Point(12, 102);
        	this.buttonLoad.Name = "buttonLoad";
        	this.buttonLoad.Size = new System.Drawing.Size(158, 47);
        	this.buttonLoad.TabIndex = 4;
        	this.buttonLoad.Text = "Zastosuj";
        	this.buttonLoad.UseVisualStyleBackColor = true;
        	this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
        	// 
        	// buttonCancel
        	// 
        	this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        	this.buttonCancel.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancel.Image")));
        	this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
        	this.buttonCancel.Location = new System.Drawing.Point(318, 102);
        	this.buttonCancel.Name = "buttonCancel";
        	this.buttonCancel.Size = new System.Drawing.Size(158, 47);
        	this.buttonCancel.TabIndex = 5;
        	this.buttonCancel.Text = "Anuluj";
        	this.buttonCancel.UseVisualStyleBackColor = true;
        	this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
        	// 
        	// radioButton1
        	// 
        	this.radioButton1.AutoSize = true;
        	this.radioButton1.Checked = true;
        	this.radioButton1.Location = new System.Drawing.Point(26, 21);
        	this.radioButton1.Name = "radioButton1";
        	this.radioButton1.Size = new System.Drawing.Size(50, 20);
        	this.radioButton1.TabIndex = 6;
        	this.radioButton1.TabStop = true;
        	this.radioButton1.Text = "Tak";
        	this.radioButton1.UseVisualStyleBackColor = true;
        	// 
        	// radioButton2
        	// 
        	this.radioButton2.AutoSize = true;
        	this.radioButton2.Location = new System.Drawing.Point(26, 58);
        	this.radioButton2.Name = "radioButton2";
        	this.radioButton2.Size = new System.Drawing.Size(47, 20);
        	this.radioButton2.TabIndex = 7;
        	this.radioButton2.Text = "Nie";
        	this.radioButton2.UseVisualStyleBackColor = true;
        	this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
        	// 
        	// groupBox1
        	// 
        	this.groupBox1.Controls.Add(this.radioButton2);
        	this.groupBox1.Controls.Add(this.radioButton1);
        	this.groupBox1.Location = new System.Drawing.Point(12, 12);
        	this.groupBox1.Name = "groupBox1";
        	this.groupBox1.Size = new System.Drawing.Size(464, 84);
        	this.groupBox1.TabIndex = 8;
        	this.groupBox1.TabStop = false;
        	this.groupBox1.Text = "Konwersja obrazu do skali szarości";
        	this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
        	// 
        	// FormRadioButton
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.BackColor = System.Drawing.SystemColors.ControlLightLight;
        	this.ClientSize = new System.Drawing.Size(483, 161);
        	this.Controls.Add(this.groupBox1);
        	this.Controls.Add(this.buttonCancel);
        	this.Controls.Add(this.buttonLoad);
        	this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        	this.Margin = new System.Windows.Forms.Padding(4);
        	this.Name = "FormRadioButton";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "Wprowadź parametry";
        	this.groupBox1.ResumeLayout(false);
        	this.groupBox1.PerformLayout();
        	this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}