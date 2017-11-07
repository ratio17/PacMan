using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
//Basic Walls ist dafür da, Wände zu beschreiben.
namespace PacMan
{
    public class BasicWall
    {
        public Point Position { get; set; }

        public Bitmap Bild { get; set; }
    }    
}
