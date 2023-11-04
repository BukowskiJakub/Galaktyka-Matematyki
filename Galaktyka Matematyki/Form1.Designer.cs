using System.Drawing.Drawing2D;

namespace Galaktyka_Matematyki
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
            label1 = new Label();
            pointsDisplay = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Consolas", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(139, 43);
            label1.TabIndex = 2;
            label1.Text = "Punkty";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pointsDisplay
            // 
            pointsDisplay.AutoSize = true;
            pointsDisplay.BackColor = Color.Transparent;
            pointsDisplay.Font = new Font("Consolas", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            pointsDisplay.ForeColor = Color.White;
            pointsDisplay.Location = new Point(147, 12);
            pointsDisplay.Name = "pointsDisplay";
            pointsDisplay.Size = new Size(179, 43);
            pointsDisplay.TabIndex = 3;
            pointsDisplay.Text = "{points}";
            pointsDisplay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1445, 1055);
            Controls.Add(pointsDisplay);
            Controls.Add(label1);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            KeyDown += Keydown;
            KeyUp += Keyup;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label pointsDisplay;
    }
}