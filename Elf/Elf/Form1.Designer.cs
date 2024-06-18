namespace Elf
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
            Welcome = new Label();
            start = new Button();
            SuspendLayout();
            // 
            // Welcome
            // 
            Welcome.AutoSize = true;
            Welcome.Font = new Font("Times New Roman", 36F, FontStyle.Italic, GraphicsUnit.Point, 162);
            Welcome.ForeColor = SystemColors.ButtonFace;
            Welcome.Location = new Point(298, 208);
            Welcome.Name = "Welcome";
            Welcome.Size = new Size(194, 55);
            Welcome.TabIndex = 0;
            Welcome.Text = "Welcome";
            Welcome.Click += label1_Click;
            // 
            // start
            // 
            start.Location = new Point(328, 303);
            start.Name = "start";
            start.Size = new Size(147, 23);
            start.TabIndex = 1;
            start.Text = "START";
            start.UseVisualStyleBackColor = true;
            start.Click += start_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(862, 626);
            Controls.Add(start);
            Controls.Add(Welcome);
            Name = "Form1";
            Text = "My precious Language";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Welcome;
        private Button start;
    }
}
