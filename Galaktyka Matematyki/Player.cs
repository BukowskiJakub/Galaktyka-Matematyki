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
    // Klasa obiektu Gracz
    public class Player : GameObject
    {
        public Player() 
        {
            this.Image = Resources.spaceship;
            this.Size = new Size(142, 158);
        }
    }
}
