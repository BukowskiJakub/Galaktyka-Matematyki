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
            Type obstacletype;

            int posX, posY;
            int type;

            posX = new Random().Next(100, 1200);
            posY = -200;

            type = new Random().Next(0, 1000);
            if (type >= 0 && type <= 100)
            {
                obstacletype = typeof(BlackHole);
            }
            else
            {
                obstacletype = typeof(Asteroid);
            }

            object obstacle = Activator.CreateInstance(obstacletype);

            obstacle.Location = new Point(posX, posY);

            gameobjects.Add(obstacle);
            Controls.Add(obstacle);
            obstacle.BringToFront();

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
                    else
                    {
                        points-=100;
                        pointsDisplay.Text = points.ToString();
                        Controls.Remove(go);
                        gameobjects.Remove(go);
                    }
                }
            }
            catch { }
        }
    }
}