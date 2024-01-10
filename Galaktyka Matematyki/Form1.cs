using Galaktyka_Matematyki.Properties;
using Microsoft.Win32;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Diagnostics.Metrics;
using System.Media;
using System.Windows.Forms;

namespace Galaktyka_Matematyki
{
    public partial class Form1 : Form
    {
        SoundPlayer ambientSound = new SoundPlayer(Resources.spaceship_sound);
        SoundPlayer correctSound = new SoundPlayer(Resources.correct_sound);
        SoundPlayer incorrectSound = new SoundPlayer(Resources.incorrect_sound);

        bool isLeft = false, isRight = false, isPause = false, isGame = false;

        List<GameObject> gameobjects = new List<GameObject>();
        Player player = new Player();

        private System.Windows.Forms.Timer updateTimer = new System.Windows.Forms.Timer();
        private System.Windows.Forms.Timer updateTimer2 = new System.Windows.Forms.Timer();
        private System.Windows.Forms.Timer generateTimer = new System.Windows.Forms.Timer();

        int points = 5;
        int correctAns = 0;
        int redCount = 0, greenCount = 0, result = 0;
        int redStart = 0, greenStart = 0;

        int generationSpeed = 3;

        int signRand = 0;
        string sign = "";

        public Form1()
        {
            InitializeComponent();

            updateTimer.Interval = 5;
            updateTimer.Tick += new EventHandler(Update);

            updateTimer2.Interval = 5;
            updateTimer2.Tick += new EventHandler(Update2);

            generateTimer.Interval = 2000;
            generateTimer.Tick += new EventHandler(Generator);
        }

        private void StartGame(object sender, EventArgs e)
        {
            // Funkcja startowa, uruchomienia rozgrywki

            ambientSound.PlayLooping();

            // Wartoœci pocz¹tkowe
            isLeft = false;
            isRight = false;
            isPause = false;
            isGame = true;
            points = 5;
            correctAns = 0;
            redCount = 0; greenCount = 0; result = 0;
            redStart = 0; greenStart = 0;
            generationSpeed = 3;
            signRand = 0;
            sign = "";

            player.Name = "player";
            player.Location = new Point(565, 785);
            Controls.Add(player);

            pointsDisplay.Text = points.ToString();

            CountRandomizer();

            updateTimer.Start();
            updateTimer2.Start();
            generateTimer.Start();

            mainMenu.Visible = false;
            mainMenu.Enabled = false;

            pointsDisplay.Visible = true;
            pointsText.Visible = true;
        }

        private void Generator(object sender, EventArgs e)
        {
            // Generator lec¹cych obiektów

            int posX, posY;
            int type;

            posX = new Random().Next(100, 1200);
            posY = -400;

            // Losowanie typu przeszkody
            type = new Random().Next(0, 1000);
            if (type >= 0 && type <= 100)
            {
                BlackHole blackHole = new BlackHole();
                blackHole.Location = new Point(posX, posY);
                gameobjects.Add(blackHole);
                Controls.Add(blackHole);
                blackHole.BringToFront();
            }
            else
            {
                Asteroid asteroid = new Asteroid();
                asteroid.Location = new Point(posX, posY);
                if (!(redCount <= 0 && greenCount <= 0))
                {
                    int color = new Random().Next(0, 3);
                    switch (color)
                    {
                        case 0:
                            if (redCount <= 0) break;
                            asteroid.Image = Resources.asteroid_red;
                            redCount--;
                            break;
                        case 1:
                            if (greenCount <= 0) break;
                            asteroid.Image = Resources.asteroid_green;
                            greenCount--;
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Maths();
                }
                gameobjects.Add(asteroid);
                Controls.Add(asteroid);
                asteroid.BringToFront();
            }

            // Wywo³anie generatora dodatkowego
            GeneratorFill(posX, posY);

            // Destrukcja obiektów poza polem widzenia
            try
            {
                foreach (GameObject go in gameobjects)
                {
                    if (go.Location.Y >= 1200)
                    {
                        Controls.Remove(go);
                        gameobjects.Remove(go);
                    }
                }
            }
            catch { }
        }

        private void GeneratorFill(int X, int Y)
        {
            // Generator dodatkowy, zwiêkszaj¹cy iloœæ obiektów lec¹cych

            int posX, posY;
            posX = new Random().Next(100, 1200);

            while (Math.Abs(posX - X) < 200)
            {
                posX = new Random().Next(100, 1200);
            }
            posY = -200;

            Asteroid asteroid = new Asteroid();
            asteroid.Location = new Point(posX, posY);

            gameobjects.Add(asteroid);
            Controls.Add(asteroid);
            asteroid.BringToFront();
        }

        private void Update(object sender, EventArgs e)
        {
            // Funkcja Update wywo³ywana cyklicznie w celu obs³ugi ruchu gracza

            if (isLeft == true && player.Location.X > -80)
            {
                Point p = new Point(player.Location.X - 5, player.Location.Y);
                player.Location = p;
            }
            else if (isRight == true && player.Location.X < 1200)
            {
                Point p = new Point(player.Location.X + 5, player.Location.Y);
                player.Location = p;
            }
        }

        private void Update2(object sender, EventArgs e)
        {
            // Aktualizacja cykliczna lec¹cych obiektów

            Collision();
            foreach (GameObject go in gameobjects)
            {
                go.Location = new Point(go.Location.X, go.Location.Y + generationSpeed);
            }
        }

        private void Keydown(object sender, KeyEventArgs e)
        {
            // Funkcja wywo³ywana przez Forms po wykryciu zdarzenia z klawiatury, obs³uga klawiszy wciskanych

            if (e.KeyCode == Keys.Left)
            {
                isLeft = true;
            }
            else if (e.KeyCode == Keys.Right)
            {
                isRight = true;
            }
        }

        private void pauseEvent()
        {
            // Obs³uga wywo³ania menu pauzy

            if (isPause)
            {
                isPause = false;

                ambientSound.PlayLooping();

                updateTimer.Start();
                updateTimer2.Start();
                generateTimer.Start();

                pauseMenu.Enabled = false;
                pauseMenu.Visible = false;

                if (infoPanel.Visible)
                {
                    infoPanel.Visible = false;
                    infoPanel.Enabled = false;
                }
            }
            else if (!isPause)
            {
                isPause = true;

                ambientSound.Stop();

                updateTimer.Stop();
                updateTimer2.Stop();
                generateTimer.Stop();

                pauseMenu.Enabled = true;
                pauseMenu.Visible = true;
                pauseMenu.BringToFront();
            }
        }

        private void Keyup(object sender, KeyEventArgs e)
        {
            // Funkcja wywo³ywana przez Forms przy zdarzeniu puszczenia przycisku klawiatury

            if (e.KeyCode == Keys.Left)
            {
                isLeft = false;
            }
            else if (e.KeyCode == Keys.Right)
            {
                isRight = false;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                if (isGame && !finishPanel.Visible && !mathMenu.Visible)
                {
                    pauseEvent();
                }
            }
        }

        private void Collision()
        {
            // Obs³uga kolizji obiektów z graczem

            try
            {
                foreach (GameObject go in gameobjects)
                {
                    if (player.Bounds.IntersectsWith(go.Bounds) && go is Asteroid)
                    {
                        points--;
                        if (points <= 0) finishEvent();
                        pointsDisplay.Text = points.ToString();
                        Controls.Remove(go);
                        gameobjects.Remove(go);
                    }
                    else if (player.Bounds.IntersectsWith(go.Bounds) && go is BlackHole)
                    {
                        finishEvent();
                    }
                }
            }
            catch { }
        }

        private void Maths()
        {
            // Wywo³anie okna wpisywania liczb dla u¿ytkownika

            mathMenu.Visible = true;
            mathMenu.Enabled = true;
            mathMenu.BringToFront();

            updateTimer.Stop();
            updateTimer2.Stop();
            generateTimer.Stop();
        }

        private void CountRandomizer()
        {
            // Funkcja odpowiedzialna za losowanie liczb do równañ oraz znaku

            redCount = new Random().Next(1, 10);
            greenCount = new Random().Next(1, 10);

            redStart = redCount;
            greenStart = greenCount;

            signRand = new Random().Next(0, 3);

            // Wybór znaku równania
            switch (signRand)
            {
                case 0:
                    sign = "x";
                    result = redCount * greenCount;
                    break;
                case 1:
                    sign = "+";
                    result = redCount + greenCount;
                    break;
                case 2:
                    sign = "-";
                    result = redCount - greenCount;
                    break;
                default:
                    break;
            }
            signLabel.Text = sign;
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            // Obs³uga przycisku zatwierdzenia podanych liczb

            if (String.Equals(redCount_box.Text, redStart.ToString()) &&
                String.Equals(greenCount_box.Text, greenStart.ToString()) &&
                String.Equals(result_box.Text, result.ToString())
               )
            {
                correctSound.Play();
                points += 25;
                correctAns++;
                pointsDisplay.Text = points.ToString();
            }
            else { incorrectSound.Play(); }

            while (gameobjects.Any())
            {
                try
                {
                    foreach (GameObject go in gameobjects)
                    {
                        Controls.Remove(go);
                        gameobjects.Remove(go);
                    }
                }
                catch { }
            }

            mathMenu.Visible = false;
            mathMenu.Enabled = false;
            redCount_box.Text = "";
            greenCount_box.Text = "";
            result_box.Text = "";

            CountRandomizer();
            generationSpeed += 1;

            updateTimer.Start();
            updateTimer2.Start();
            generateTimer.Start();

            ambientSound.Play();
        }

        private void infoBackButton_Click(object sender, EventArgs e)
        {
            // Obs³uga przycisku powrotu z panelu Info

            infoPanel.Visible = false;
            infoPanel.Enabled = false;

            if (!isPause)
            {
                mainMenu.Enabled = true;
                mainMenu.Visible = true;
            }
            else if (isPause)
            {
                pauseMenu.Enabled = true;
                pauseMenu.Visible = true;
            }
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            // Obs³uga przycisku wejœcia do panelu Info

            if (sender == infoButton)
            {
                mainMenu.Enabled = false;
                mainMenu.Visible = false;
            }
            else if (sender == infoButton_2)
            {
                pauseMenu.Enabled = false;
                pauseMenu.Visible = false;
            }

            infoPanel.Visible = true;
            infoPanel.Enabled = true;
            infoPanel.BringToFront();
        }

        private void resumeButton_Click(object sender, EventArgs e)
        {
            // Obs³uga przycisku wznowienia w menu pauzy

            pauseEvent();
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            // Obs³uga przycisku zakoñczenia rozgrywki

            finishEvent();
        }

        private void finishEvent()
        {
            // Funkcja wywo³uj¹ca panel podsumowania

            isPause = false;

            ambientSound.Stop();

            pauseMenu.Visible = false;
            pointsText.Visible = false;
            pointsDisplay.Visible = false;

            finishPanel.Visible = true;
            finishPanel.Enabled = true;
            finishPanel.BringToFront();

            updateTimer.Stop();
            updateTimer2.Stop();
            generateTimer.Stop();

            pointsTotal.Text = points.ToString();
            correctTotal.Text = correctAns.ToString();
        }

        private void backToMenuButton_Click(object sender, EventArgs e)
        {
            // Obs³uga przycisku powrotu do Menu g³ównego

            isGame = false;

            while (gameobjects.Any())
            {
                try
                {
                    foreach (GameObject go in gameobjects)
                    {
                        Controls.Remove(go);
                        gameobjects.Remove(go);
                    }
                }
                catch { }
            }
            Controls.Remove(player);

            finishPanel.Visible = false;
            finishPanel.Enabled = false;

            mainMenu.Visible = true;
            mainMenu.Enabled = true;
        }
    }
}