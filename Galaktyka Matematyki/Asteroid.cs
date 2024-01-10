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
    // Klasa obiektu Asteroida
    public class Asteroid : GameObject
    {
        public Asteroid()
        {
            this.Image = Resources.asteroid;
            this.Size = new Size(116, 127);
        }
    }
}
