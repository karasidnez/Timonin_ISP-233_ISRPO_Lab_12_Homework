namespace lab_12_Hoomework
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Time1 = new Label();
            Clicki1 = new Label();
            Reset = new Button();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Time1
            // 
            Time1.AutoSize = true;
            Time1.Font = new Font("Segoe UI", 20F);
            Time1.Location = new Point(82, 30);
            Time1.Name = "Time1";
            Time1.Size = new Size(123, 37);
            Time1.TabIndex = 1;
            Time1.Text = "Время: 0";
            // 
            // Clicki1
            // 
            Clicki1.AutoSize = true;
            Clicki1.Font = new Font("Segoe UI", 20F);
            Clicki1.Location = new Point(82, 102);
            Clicki1.Name = "Clicki1";
            Clicki1.Size = new Size(282, 37);
            Clicki1.TabIndex = 2;
            Clicki1.Text = "Количество кликов: 0";
            // 
            // Reset
            // 
            Reset.Location = new Point(870, 312);
            Reset.Name = "Reset";
            Reset.Size = new Size(157, 110);
            Reset.TabIndex = 3;
            Reset.Text = "Reset";
            Reset.UseVisualStyleBackColor = true;
            Reset.Click += Reset_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 162);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(695, 477);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 674);
            Controls.Add(pictureBox1);
            Controls.Add(Reset);
            Controls.Add(Clicki1);
            Controls.Add(Time1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Time1;
        private Label Clicki1;
        private Button Reset;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}
