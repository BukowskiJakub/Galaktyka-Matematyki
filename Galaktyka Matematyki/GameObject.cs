using Galaktyka_Matematyki.Properties;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Galaktyka_Matematyki
{
    public class GameObject : PictureBoxWithInterpolationMode
    {
        public GameObject()
        {
            this.InterpolationMode = InterpolationMode.NearestNeighbor;
            this.SizeMode = PictureBoxSizeMode.Zoom;
            this.BackColor = Color.Transparent;
        }
    }
}