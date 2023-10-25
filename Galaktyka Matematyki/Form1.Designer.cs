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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBoxWithInterpolationMode1 = new PictureBoxWithInterpolationMode();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWithInterpolationMode1).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxWithInterpolationMode1
            // 
            pictureBoxWithInterpolationMode1.BackColor = Color.Transparent;
            pictureBoxWithInterpolationMode1.Image = (Image)resources.GetObject("pictureBoxWithInterpolationMode1.Image");
            pictureBoxWithInterpolationMode1.InterpolationMode = InterpolationMode.NearestNeighbor;
            pictureBoxWithInterpolationMode1.Location = new Point(55, 116);
            pictureBoxWithInterpolationMode1.Name = "pictureBoxWithInterpolationMode1";
            pictureBoxWithInterpolationMode1.Size = new Size(314, 128);
            pictureBoxWithInterpolationMode1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxWithInterpolationMode1.TabIndex = 0;
            pictureBoxWithInterpolationMode1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1264, 985);
            Controls.Add(pictureBoxWithInterpolationMode1);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBoxWithInterpolationMode1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBoxWithInterpolationMode pictureBoxWithInterpolationMode1;
    }
}