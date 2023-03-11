namespace App
{
    partial class Screen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            hiperlink = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(33, 175);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(262, 254);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // hiperlink
            // 
            hiperlink.BorderStyle = BorderStyle.FixedSingle;
            hiperlink.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            hiperlink.Location = new Point(33, 38);
            hiperlink.Name = "hiperlink";
            hiperlink.PlaceholderText = "Cole o link aqui..";
            hiperlink.Size = new Size(262, 36);
            hiperlink.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(203, 83);
            button1.Name = "button1";
            button1.Size = new Size(92, 31);
            button1.TabIndex = 2;
            button1.Text = "Gerar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Screen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 450);
            Controls.Add(button1);
            Controls.Add(hiperlink);
            Controls.Add(pictureBox1);
            Name = "Screen";
            Text = "QRCode";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox hiperlink;
        private Button button1;
    }
}