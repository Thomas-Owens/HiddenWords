namespace HiddenWords
{
    partial class TestForm
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
            this.ConvertButton = new System.Windows.Forms.Button();
            this.LoadedPictureTest = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBrowseButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.LoadedPictureTest)).BeginInit();
            this.SuspendLayout();
            // 
            // ConvertButton
            // 
            this.ConvertButton.Location = new System.Drawing.Point(87, 210);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(100, 23);
            this.ConvertButton.TabIndex = 0;
            this.ConvertButton.Text = "Encode Image";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.convertButton_click);
            // 
            // LoadedPictureTest
            // 
            this.LoadedPictureTest.Location = new System.Drawing.Point(236, 39);
            this.LoadedPictureTest.Name = "LoadedPictureTest";
            this.LoadedPictureTest.Size = new System.Drawing.Size(166, 151);
            this.LoadedPictureTest.TabIndex = 3;
            this.LoadedPictureTest.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Supported Image Files(*.BMP;*.JPG)|*.BMP;*.JPG|All files (*.*)|*.*";
            // 
            // pictureBrowseButton
            // 
            this.pictureBrowseButton.Location = new System.Drawing.Point(276, 10);
            this.pictureBrowseButton.Name = "pictureBrowseButton";
            this.pictureBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.pictureBrowseButton.TabIndex = 4;
            this.pictureBrowseButton.Text = "Load Image";
            this.pictureBrowseButton.UseVisualStyleBackColor = true;
            this.pictureBrowseButton.Click += new System.EventHandler(this.pictureBrowseButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(46, 39);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 151);
            this.textBox1.TabIndex = 5;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Supported Image Files(*.BMP)|*.BMP";
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 291);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBrowseButton);
            this.Controls.Add(this.LoadedPictureTest);
            this.Controls.Add(this.ConvertButton);
            this.Name = "TestForm";
            this.Text = "Testform of suffer";
            ((System.ComponentModel.ISupportInitialize)(this.LoadedPictureTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.PictureBox LoadedPictureTest;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button pictureBrowseButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

