using Galaktyka_Matematyki.Properties;
using Microsoft.Win32;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Windows.Forms;

namespace Galaktyka_Matematyki
{
    public partial class Form1 : Form
    {
        bool isLeft = false, isRight = false;

        List<GameObject> gameobjects = new List<GameObject>();
        Player player = new Player();

        private System.Windows.Forms.Timer updateTimer = new System.Windows.Forms.Timer();
        private System.Windows.Forms.Timer updateTimer2 = new System.Windows.Forms.Timer();
        private System.Windows.Forms.Timer generateTimer = new System.Windows.Forms.Timer();

        int points = 5;
        int redCount = 0, greenCount = 0, result = 0;
        int redStart = 0, greenStart = 0;

        int signRand = 0;
        string sign = "";

        public Form1()
        {
            InitializeComponent();

            updateTimer.Interval = 5;
            updateTimer.Tick += new EventHandler(Update);
            updateTimer.Start();

            updateTimer2.Interval = 5;
            updateTimer2.Tick += new EventHandler(Update2);
            updateTimer2.Start();

            generateTimer.Interval = 2000;
            generateTimer.Tick += new EventHandler(Generator);
            generateTimer.Start();

            player.Name = "player";
            player.Location = new Point(565, 785);
            Controls.Add(player);

            pointsDisplay.Text = points.ToString();

            CountRandomizer();
        }

        private void Generator(object sender, EventArgs e)
        {
            int posX, posY;
            int type;

            posX = new Random().Next(100, 1200);
            posY = -200;

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

        private void Update(object sender, EventArgs e)
        {
            if (isLeft == true)
            {
                Point p = new Point(player.Location.X - 5, player.Location.Y);
                player.Location = p;
            }
            else if (isRight == true)
            {
                Point p = new Point(player.Location.X + 5, player.Location.Y);
                player.Location = p;
            }

            debugLabel.Text = redStart + sign + greenStart + " = " + result;
        }

        private void Update2(object sender, EventArgs e)
        {
            Collision();
            foreach (GameObject go in gameobjects)
            {
                go.Location = new Point(go.Location.X, go.Location.Y + 3);
            }
        }

        private void Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                isLeft = true;
            }
            else if (e.KeyCode == Keys.Right)
            {
                isRight = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                pauseMenu();
            }
        }

        private void pauseMenu()
        {
            throw new NotImplementedException();
        }

        private void Keyup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                isLeft = false;
            }
            else if (e.KeyCode == Keys.Right)
            {
                isRight = false;
            }
        }

        private void Collision()
        {
            try
            {
                foreach (GameObject go in gameobjects)
                {
                    if (player.Bounds.IntersectsWith(go.Bounds) && go is Asteroid)
                    {
                        points--;
                        pointsDisplay.Text = points.ToString();
                        Controls.Remove(go);
                        gameobjects.Remove(go);
                    }
                    else if (player.Bounds.IntersectsWith(go.Bounds) && go is BlackHole)
                    {
                        points -= 100;
                        pointsDisplay.Text = points.ToString();
                        Controls.Remove(go);
                        gameobjects.Remove(go);
                    }
                }
            }
            catch { }
        }

        private void Maths()
        {
            mathMenu.Visible = true;
            mathMenu.Enabled = true;
            mathMenu.BringToFront();

            updateTimer.Stop();
            updateTimer2.Stop();
            generateTimer.Stop();
        }

        private void CountRandomizer()
        {
            redCount = new Random().Next(1, 10);
            greenCount = new Random().Next(1, 10);

            redStart = redCount;
            greenStart = greenCount;

            signRand = new Random().Next(0, 3);

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
            if (String.Equals(redCount_box.Text, redStart.ToString()) &&
                String.Equals(greenCount_box.Text, greenStart.ToString()) &&
                String.Equals(result_box.Text, result.ToString())
               )
            {
                points += 100;
                pointsDisplay.Text = points.ToString();
            }

            //    Nie dziala :(
            try
            {
                foreach (GameObject go in gameobjects)
                {
                    Controls.Remove(go);
                    gameobjects.Remove(go);
                }
            }
            catch { }

            mathMenu.Visible = false;
            mathMenu.Enabled = false;
            redCount_box.Text = "";
            greenCount_box.Text = "";
            result_box.Text = "";

            CountRandomizer();

            updateTimer.Start();
            updateTimer2.Start();
            generateTimer.Start();
        }
    }
}