using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PacMan
{
    public class Player_Panel : System.Windows.Forms.Panel
    {       
        public void GoUp ()
        {
            var NP = new Point(this.Location.X, this.Location.Y - 30);
            this.Location=NP;
        }
        public void GoDown ()
        {
            var NP = new Point(this.Location.X, this.Location.Y + 30);
            this.Location = NP;
        }
        public void GoRight ()
        {
            var NP = new Point(this.Location.X + 30, this.Location.Y);
            this.Location = NP;
        }
        public void GoLeft ()
        {
            var NP = new Point(this.Location.X - 30, this.Location.Y);
            this.Location = NP;
        }
    }
}
