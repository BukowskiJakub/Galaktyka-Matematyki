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
    // Klasa obiektu Czarna Dziura
    public class BlackHole : GameObject
    {
        public BlackHole()
        {
            this.Image = Resources.black_hole;
            this.Size = new Size(119, 128);
        }
    }
}
