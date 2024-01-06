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
            pointsText = new Label();
            pointsDisplay = new Label();
            debugLabel = new Label();
            mathMenu = new Panel();
            result_box = new TextBox();
            equalSign_label = new Label();
            sendButton = new Button();
            signLabel = new Label();
            greenCount_box = new TextBox();
            redCount_box = new TextBox();
            mainMenu = new Panel();
            titleLabel = new Label();
            pictureBoxWithInterpolationMode1 = new PictureBoxWithInterpolationMode();
            infoButton = new Button();
            playButton = new Button();
            pauseMenu = new Panel();
            infoButton_2 = new Button();
            finishButton = new Button();
            resumeButton = new Button();
            pauseLabel = new Label();
            infoPanel = new Panel();
            infoBackButton = new Button();
            infoLabel = new Label();
            finishPanel = new Panel();
            correctTotal = new Label();
            pointsTotal = new Label();
            correctTotal_label = new Label();
            pointsTotal_label = new Label();
            label2 = new Label();
            label1 = new Label();
            backToMenuButton = new Button();
            mathMenu.SuspendLayout();
            mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWithInterpolationMode1).BeginInit();
            pauseMenu.SuspendLayout();
            infoPanel.SuspendLayout();
            finishPanel.SuspendLayout();
            SuspendLayout();
            // 
            // pointsText
            // 
            pointsText.AutoSize = true;
            pointsText.BackColor = Color.Transparent;
            pointsText.Font = new Font("Consolas", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            pointsText.ForeColor = Color.White;
            pointsText.Location = new Point(12, 9);
            pointsText.Name = "pointsText";
            pointsText.Size = new Size(111, 34);
            pointsText.TabIndex = 2;
            pointsText.Text = "Punkty";
            pointsText.TextAlign = ContentAlignment.MiddleCenter;
            pointsText.Visible = false;
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
            pointsDisplay.Visible = false;
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
            sendButton.BackgroundImage = Properties.Resources.button;
            sendButton.BackgroundImageLayout = ImageLayout.Stretch;
            sendButton.FlatStyle = FlatStyle.Popup;
            sendButton.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            sendButton.ForeColor = Color.White;
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
            // mainMenu
            // 
            mainMenu.BackColor = Color.Gray;
            mainMenu.Controls.Add(titleLabel);
            mainMenu.Controls.Add(pictureBoxWithInterpolationMode1);
            mainMenu.Controls.Add(infoButton);
            mainMenu.Controls.Add(playButton);
            mainMenu.Location = new Point(429, 160);
            mainMenu.Name = "mainMenu";
            mainMenu.Size = new Size(489, 591);
            mainMenu.TabIndex = 6;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Consolas", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(65, 96);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(219, 86);
            titleLabel.TabIndex = 2;
            titleLabel.Text = "Galaktyka\r\nMatematyki";
            // 
            // pictureBoxWithInterpolationMode1
            // 
            pictureBoxWithInterpolationMode1.BackgroundImageLayout = ImageLayout.None;
            pictureBoxWithInterpolationMode1.Image = Properties.Resources.game_logo;
            pictureBoxWithInterpolationMode1.InterpolationMode = InterpolationMode.NearestNeighbor;
            pictureBoxWithInterpolationMode1.Location = new Point(263, 56);
            pictureBoxWithInterpolationMode1.Name = "pictureBoxWithInterpolationMode1";
            pictureBoxWithInterpolationMode1.Size = new Size(186, 160);
            pictureBoxWithInterpolationMode1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxWithInterpolationMode1.TabIndex = 3;
            pictureBoxWithInterpolationMode1.TabStop = false;
            // 
            // infoButton
            // 
            infoButton.BackgroundImage = Properties.Resources.button;
            infoButton.BackgroundImageLayout = ImageLayout.Stretch;
            infoButton.FlatStyle = FlatStyle.Popup;
            infoButton.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            infoButton.ForeColor = Color.White;
            infoButton.Location = new Point(134, 406);
            infoButton.Name = "infoButton";
            infoButton.Size = new Size(216, 103);
            infoButton.TabIndex = 1;
            infoButton.Text = "Info";
            infoButton.UseVisualStyleBackColor = true;
            infoButton.Click += infoButton_Click;
            // 
            // playButton
            // 
            playButton.BackgroundImage = Properties.Resources.button;
            playButton.BackgroundImageLayout = ImageLayout.Stretch;
            playButton.FlatStyle = FlatStyle.Popup;
            playButton.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            playButton.ForeColor = Color.White;
            playButton.Location = new Point(134, 256);
            playButton.Name = "playButton";
            playButton.Size = new Size(216, 103);
            playButton.TabIndex = 0;
            playButton.Text = "Graj";
            playButton.UseVisualStyleBackColor = true;
            playButton.Click += StartGame;
            // 
            // pauseMenu
            // 
            pauseMenu.BackColor = Color.Gray;
            pauseMenu.Controls.Add(infoButton_2);
            pauseMenu.Controls.Add(finishButton);
            pauseMenu.Controls.Add(resumeButton);
            pauseMenu.Controls.Add(pauseLabel);
            pauseMenu.Location = new Point(429, 97);
            pauseMenu.Name = "pauseMenu";
            pauseMenu.Size = new Size(489, 474);
            pauseMenu.TabIndex = 8;
            pauseMenu.Visible = false;
            // 
            // infoButton_2
            // 
            infoButton_2.BackgroundImage = Properties.Resources.button;
            infoButton_2.BackgroundImageLayout = ImageLayout.Stretch;
            infoButton_2.FlatStyle = FlatStyle.Popup;
            infoButton_2.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            infoButton_2.ForeColor = Color.White;
            infoButton_2.Location = new Point(134, 241);
            infoButton_2.Name = "infoButton_2";
            infoButton_2.Size = new Size(216, 72);
            infoButton_2.TabIndex = 3;
            infoButton_2.Text = "Info";
            infoButton_2.UseVisualStyleBackColor = true;
            infoButton_2.Click += infoButton_Click;
            // 
            // finishButton
            // 
            finishButton.BackgroundImage = Properties.Resources.button;
            finishButton.BackgroundImageLayout = ImageLayout.Stretch;
            finishButton.FlatStyle = FlatStyle.Popup;
            finishButton.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            finishButton.ForeColor = Color.White;
            finishButton.Location = new Point(134, 350);
            finishButton.Name = "finishButton";
            finishButton.Size = new Size(216, 72);
            finishButton.TabIndex = 2;
            finishButton.Text = "Zakończ";
            finishButton.UseVisualStyleBackColor = true;
            finishButton.Click += finishButton_Click;
            // 
            // resumeButton
            // 
            resumeButton.BackgroundImage = Properties.Resources.button;
            resumeButton.BackgroundImageLayout = ImageLayout.Stretch;
            resumeButton.FlatStyle = FlatStyle.Popup;
            resumeButton.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            resumeButton.ForeColor = Color.White;
            resumeButton.Location = new Point(134, 126);
            resumeButton.Name = "resumeButton";
            resumeButton.Size = new Size(216, 72);
            resumeButton.TabIndex = 1;
            resumeButton.Text = "Wznów";
            resumeButton.UseVisualStyleBackColor = true;
            resumeButton.Click += resumeButton_Click;
            // 
            // pauseLabel
            // 
            pauseLabel.AutoSize = true;
            pauseLabel.Font = new Font("Consolas", 36F, FontStyle.Bold, GraphicsUnit.Point);
            pauseLabel.Location = new Point(166, 29);
            pauseLabel.Name = "pauseLabel";
            pauseLabel.Size = new Size(154, 56);
            pauseLabel.TabIndex = 0;
            pauseLabel.Text = "Pauza";
            // 
            // infoPanel
            // 
            infoPanel.BackColor = Color.Gray;
            infoPanel.Controls.Add(infoBackButton);
            infoPanel.Controls.Add(infoLabel);
            infoPanel.Enabled = false;
            infoPanel.ImeMode = ImeMode.NoControl;
            infoPanel.Location = new Point(267, 160);
            infoPanel.Name = "infoPanel";
            infoPanel.Size = new Size(836, 411);
            infoPanel.TabIndex = 7;
            infoPanel.Visible = false;
            // 
            // infoBackButton
            // 
            infoBackButton.BackgroundImage = Properties.Resources.button;
            infoBackButton.BackgroundImageLayout = ImageLayout.Stretch;
            infoBackButton.FlatStyle = FlatStyle.Popup;
            infoBackButton.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            infoBackButton.ForeColor = Color.White;
            infoBackButton.Location = new Point(339, 313);
            infoBackButton.Name = "infoBackButton";
            infoBackButton.Size = new Size(143, 69);
            infoBackButton.TabIndex = 1;
            infoBackButton.Text = "wróć";
            infoBackButton.UseVisualStyleBackColor = true;
            infoBackButton.Click += infoBackButton_Click;
            // 
            // infoLabel
            // 
            infoLabel.AutoSize = true;
            infoLabel.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            infoLabel.Location = new Point(39, 52);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new Size(770, 220);
            infoLabel.TabIndex = 0;
            infoLabel.Text = resources.GetString("infoLabel.Text");
            // 
            // finishPanel
            // 
            finishPanel.BackColor = Color.Gray;
            finishPanel.Controls.Add(correctTotal);
            finishPanel.Controls.Add(pointsTotal);
            finishPanel.Controls.Add(correctTotal_label);
            finishPanel.Controls.Add(pointsTotal_label);
            finishPanel.Controls.Add(label2);
            finishPanel.Controls.Add(label1);
            finishPanel.Controls.Add(backToMenuButton);
            finishPanel.Location = new Point(456, 126);
            finishPanel.Name = "finishPanel";
            finishPanel.Size = new Size(437, 510);
            finishPanel.TabIndex = 9;
            finishPanel.Visible = false;
            // 
            // correctTotal
            // 
            correctTotal.AutoSize = true;
            correctTotal.Font = new Font("Consolas", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            correctTotal.ForeColor = Color.Cyan;
            correctTotal.Location = new Point(311, 262);
            correctTotal.Name = "correctTotal";
            correctTotal.Size = new Size(47, 34);
            correctTotal.TabIndex = 9;
            correctTotal.Text = "{}";
            // 
            // pointsTotal
            // 
            pointsTotal.AutoSize = true;
            pointsTotal.Font = new Font("Consolas", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            pointsTotal.ForeColor = Color.Cyan;
            pointsTotal.Location = new Point(311, 202);
            pointsTotal.Name = "pointsTotal";
            pointsTotal.Size = new Size(47, 34);
            pointsTotal.TabIndex = 8;
            pointsTotal.Text = "{}";
            // 
            // correctTotal_label
            // 
            correctTotal_label.AutoSize = true;
            correctTotal_label.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            correctTotal_label.Location = new Point(104, 248);
            correctTotal_label.Name = "correctTotal_label";
            correctTotal_label.Size = new Size(155, 56);
            correctTotal_label.TabIndex = 7;
            correctTotal_label.Text = "Poprawne\r\nodpowiedzi:";
            // 
            // pointsTotal_label
            // 
            pointsTotal_label.AutoSize = true;
            pointsTotal_label.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            pointsTotal_label.Location = new Point(104, 208);
            pointsTotal_label.Name = "pointsTotal_label";
            pointsTotal_label.Size = new Size(103, 28);
            pointsTotal_label.TabIndex = 6;
            pointsTotal_label.Text = "Punkty:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(76, 153);
            label2.Name = "label2";
            label2.Size = new Size(223, 34);
            label2.TabIndex = 5;
            label2.Text = "Podsumowanie:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(76, 27);
            label1.Name = "label1";
            label1.Size = new Size(310, 56);
            label1.TabIndex = 4;
            label1.Text = "Koniec gry!";
            // 
            // backToMenuButton
            // 
            backToMenuButton.BackgroundImage = Properties.Resources.button;
            backToMenuButton.BackgroundImageLayout = ImageLayout.Stretch;
            backToMenuButton.FlatStyle = FlatStyle.Popup;
            backToMenuButton.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            backToMenuButton.ForeColor = Color.White;
            backToMenuButton.Location = new Point(76, 401);
            backToMenuButton.Name = "backToMenuButton";
            backToMenuButton.Size = new Size(293, 72);
            backToMenuButton.TabIndex = 3;
            backToMenuButton.Text = "Wróć do menu";
            backToMenuButton.UseVisualStyleBackColor = true;
            backToMenuButton.Click += backToMenuButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(3, 0, 70);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1264, 985);
            Controls.Add(finishPanel);
            Controls.Add(pauseMenu);
            Controls.Add(mainMenu);
            Controls.Add(mathMenu);
            Controls.Add(infoPanel);
            Controls.Add(pointsDisplay);
            Controls.Add(pointsText);
            Controls.Add(debugLabel);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Galaktyka Matematyki";
            KeyDown += Keydown;
            KeyUp += Keyup;
            mathMenu.ResumeLayout(false);
            mathMenu.PerformLayout();
            mainMenu.ResumeLayout(false);
            mainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWithInterpolationMode1).EndInit();
            pauseMenu.ResumeLayout(false);
            pauseMenu.PerformLayout();
            infoPanel.ResumeLayout(false);
            infoPanel.PerformLayout();
            finishPanel.ResumeLayout(false);
            finishPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label pointsText;
        private Label pointsDisplay;
        private Label debugLabel;
        private Panel mathMenu;
        private TextBox redCount_box;
        private Button sendButton;
        private Label signLabel;
        private TextBox greenCount_box;
        private TextBox result_box;
        private Label equalSign_label;
        private Panel mainMenu;
        private Label titleLabel;
        private Button infoButton;
        private Button playButton;
        private Panel infoPanel;
        private Label infoLabel;
        private Button infoBackButton;
        private PictureBoxWithInterpolationMode pictureBoxWithInterpolationMode1;
        private Panel panel1;
        private Button finishButton;
        private Button resumeButton;
        private Label pauseLabel;
        private Panel pauseMenu;
        private Button infoButton_2;
        private Panel finishPanel;
        private Label label2;
        private Label label1;
        private Button backToMenuButton;
        private Label correctTotal_label;
        private Label pointsTotal_label;
        private Label correctTotal;
        private Label pointsTotal;
    }
}