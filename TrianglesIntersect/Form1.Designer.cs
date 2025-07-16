namespace TrianglesIntersect
{
    partial class Form1
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
            nextTrianglesButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.MidnightBlue;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(645, 451);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += pictureBox1_Paint;
            // 
            // nextTrianglesButton
            // 
            nextTrianglesButton.BackColor = Color.Navy;
            nextTrianglesButton.FlatAppearance.BorderSize = 0;
            nextTrianglesButton.FlatStyle = FlatStyle.Flat;
            nextTrianglesButton.Font = new Font("Segoe UI Semilight", 16F);
            nextTrianglesButton.ForeColor = Color.FromArgb(192, 218, 255);
            nextTrianglesButton.Location = new Point(0, 451);
            nextTrianglesButton.Name = "nextTrianglesButton";
            nextTrianglesButton.Size = new Size(644, 50);
            nextTrianglesButton.TabIndex = 1;
            nextTrianglesButton.Text = "Next Triangle Pair";
            nextTrianglesButton.UseVisualStyleBackColor = false;
            nextTrianglesButton.Click += nextTrianglesButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            ClientSize = new Size(644, 499);
            Controls.Add(nextTrianglesButton);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button nextTrianglesButton;
    }
}
