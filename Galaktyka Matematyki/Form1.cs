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
        private System.Windows.Forms.Timer generateTimer = new System.Windows.Forms.Timer();

        int points = 0;

        public Form1()
        {
            InitializeComponent();

            updateTimer.Interval = 10;
            updateTimer.Tick += new EventHandler(Update);
            updateTimer.Start();

            generateTimer.Interval = 2000;
            generateTimer.Tick += new EventHandler(Generator);
            generateTimer.Start();

            player.Name = "player";
            player.Location = new Point(569, 800);
            Controls.Add(player);
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

            foreach (Asteroid a in asteroids)
            {
                if (a.Location.Y >= 1200)
                {
                    Controls.Remove(a);
                    a.Dispose();
                }
            }
        }

        private void Update(object sender, EventArgs e)
        {
            foreach (Asteroid a in asteroids)
            {
                a.Location = new Point(a.Location.X, a.Location.Y + 5);
            }

            //pictureBoxWithInterpolationMode1.Location = new Point(pictureBoxWithInterpolationMode1.Location.X, pictureBoxWithInterpolationMode1.Location.Y + 1);
            if (isLeft == true)
            {
                Point punkt = new Point(player.Location.X - 10, player.Location.Y);
                player.Location = punkt;
            }
            else if (isRight == true)
            {
                Point punkt = new Point(player.Location.X + 10, player.Location.Y);
                player.Location = punkt;
            }
            Collision();
        }
        private void Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                isLeft = true;
                //pictureBoxWithInterpolationMode2.Image.RotateFlip(RotateFlipType.Rotate90FlipXY);
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

        void Collision()
        {
        }
    }
}