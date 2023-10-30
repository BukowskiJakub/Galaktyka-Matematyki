using Galaktyka_Matematyki.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Galaktyka_Matematyki
{
    public class Player : PictureBoxWithInterpolationMode
    {
        public Player() 
        {
            this.Image = Resources.spaceship;
            this.InterpolationMode = InterpolationMode.NearestNeighbor;
            this.Size = new Size(142, 158);
            this.SizeMode = PictureBoxSizeMode.Zoom;
            this.BackColor = Color.Transparent;
        }
    }
}
