using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Windows.Forms;

namespace Galaktyka_Matematyki
{
    public partial class Form1 : Form
    {
        bool isLeft = false, isRight = false;

        List<Asteroid> asteroids = new List<Asteroid>();
        Player player = new Player();

        private System.Windows.Forms.Timer updateTimer = new System.Windows.Forms.Timer();
        private System.Windows.Forms.Timer updateTimer2 = new System.Windows.Forms.Timer();
        private System.Windows.Forms.Timer generateTimer = new System.Windows.Forms.Timer();

        int points = 5;

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
            player.Location = new Point(569, 800);
            Controls.Add(player);

            pointsDisplay.Text = points.ToString();
        }

        private void Generator(object sender, EventArgs e)
        {
            Asteroid asteroid = new Asteroid();

            int posX, posY;

            posX = new Random().Next(100, 1200);
            posY = -200;

            asteroid.Location = new Point(posX, posY);

            asteroids.Add(asteroid);
            Controls.Add(asteroid);
            asteroid.BringToFront();

            try
            {
                foreach (Asteroid a in asteroids)
                {
                    if (a.Location.Y >= 1200)
                    {
                        Controls.Remove(a);
                        asteroids.Remove(a);
                    }
                }
            }
            catch {}
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
        }

        private void Update2(object sender, EventArgs e)
        {
            Collision();
            foreach (Asteroid a in asteroids)
            {
                a.Location = new Point(a.Location.X, a.Location.Y + 3);
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
                foreach (Asteroid a in asteroids)
                {
                    if (player.Bounds.IntersectsWith(a.Bounds))
                    {
                        points--;
                        pointsDisplay.Text = points.ToString();
                        Controls.Remove(a);
                        asteroids.Remove(a);
                    }
                }
            }
            catch { }
        }
    }
}