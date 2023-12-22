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
            debugLabel = new Label();
            mathMenu = new Panel();
            result_box = new TextBox();
            equalSign_label = new Label();
            sendButton = new Button();
            signLabel = new Label();
            greenCount_box = new TextBox();
            redCount_box = new TextBox();
            mathMenu.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Consolas", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(111, 34);
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
            pointsDisplay.Location = new Point(129, 9);
            pointsDisplay.Name = "pointsDisplay";
            pointsDisplay.Size = new Size(143, 34);
            pointsDisplay.TabIndex = 3;
            pointsDisplay.Text = "{points}";
            pointsDisplay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // debugLabel
            // 
            debugLabel.AutoSize = true;
            debugLabel.BackColor = Color.Transparent;
            debugLabel.Font = new Font("Consolas", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            debugLabel.ForeColor = Color.White;
            debugLabel.Location = new Point(12, 97);
            debugLabel.Name = "debugLabel";
            debugLabel.Size = new Size(127, 34);
            debugLabel.TabIndex = 4;
            debugLabel.Text = "numbers";
            debugLabel.TextAlign = ContentAlignment.MiddleCenter;
            debugLabel.Visible = false;
            // 
            // mathMenu
            // 
            mathMenu.BackColor = Color.Gray;
            mathMenu.Controls.Add(result_box);
            mathMenu.Controls.Add(equalSign_label);
            mathMenu.Controls.Add(sendButton);
            mathMenu.Controls.Add(signLabel);
            mathMenu.Controls.Add(greenCount_box);
            mathMenu.Controls.Add(redCount_box);
            mathMenu.Location = new Point(365, 301);
            mathMenu.Name = "mathMenu";
            mathMenu.Size = new Size(614, 301);
            mathMenu.TabIndex = 5;
            mathMenu.Visible = false;
            // 
            // result_box
            // 
            result_box.BackColor = Color.FromArgb(224, 224, 224);
            result_box.BorderStyle = BorderStyle.None;
            result_box.Font = new Font("Consolas", 48F, FontStyle.Bold, GraphicsUnit.Point);
            result_box.Location = new Point(453, 71);
            result_box.Name = "result_box";
            result_box.Size = new Size(100, 75);
            result_box.TabIndex = 5;
            result_box.TextAlign = HorizontalAlignment.Center;
            // 
            // equalSign_label
            // 
            equalSign_label.AutoSize = true;
            equalSign_label.Font = new Font("Consolas", 48F, FontStyle.Bold, GraphicsUnit.Point);
            equalSign_label.Location = new Point(380, 71);
            equalSign_label.Name = "equalSign_label";
            equalSign_label.Size = new Size(67, 75);
            equalSign_label.TabIndex = 4;
            equalSign_label.Text = "=";
            // 
            // sendButton
            // 
            sendButton.AutoSize = true;
            sendButton.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            sendButton.Location = new Point(241, 230);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(143, 40);
            sendButton.TabIndex = 3;
            sendButton.Text = "Zatwierdź";
            sendButton.UseVisualStyleBackColor = true;
            sendButton.Click += sendButton_Click;
            // 
            // signLabel
            // 
            signLabel.AutoSize = true;
            signLabel.Font = new Font("Consolas", 48F, FontStyle.Bold, GraphicsUnit.Point);
            signLabel.Location = new Point(185, 71);
            signLabel.Name = "signLabel";
            signLabel.Size = new Size(67, 75);
            signLabel.TabIndex = 2;
            signLabel.Text = "?";
            // 
            // greenCount_box
            // 
            greenCount_box.BackColor = Color.LightGreen;
            greenCount_box.BorderStyle = BorderStyle.None;
            greenCount_box.Font = new Font("Consolas", 48F, FontStyle.Bold, GraphicsUnit.Point);
            greenCount_box.Location = new Point(258, 71);
            greenCount_box.Name = "greenCount_box";
            greenCount_box.Size = new Size(100, 75);
            greenCount_box.TabIndex = 1;
            greenCount_box.TextAlign = HorizontalAlignment.Center;
            // 
            // redCount_box
            // 
            redCount_box.BackColor = Color.LightCoral;
            redCount_box.BorderStyle = BorderStyle.None;
            redCount_box.Font = new Font("Consolas", 48F, FontStyle.Bold, GraphicsUnit.Point);
            redCount_box.Location = new Point(64, 71);
            redCount_box.Name = "redCount_box";
            redCount_box.Size = new Size(100, 75);
            redCount_box.TabIndex = 0;
            redCount_box.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(3, 0, 70);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1264, 985);
            Controls.Add(mathMenu);
            Controls.Add(debugLabel);
            Controls.Add(pointsDisplay);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            KeyDown += Keydown;
            KeyUp += Keyup;
            mathMenu.ResumeLayout(false);
            mathMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label pointsDisplay;
        private Label debugLabel;
        private Panel mathMenu;
        private TextBox redCount_box;
        private Button sendButton;
        private Label signLabel;
        private TextBox greenCount_box;
        private TextBox result_box;
        private Label equalSign_label;
    }
}