using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacMan
{
    public class Target
    {
        public Target()
        {
            var R = new Random();
            Lebenszeit = R.Next(3, 8);
        } 

        public Point Position { get; set; }

        public int Lebenszeit { get; set; }

        private Panel m_Objekt;
        public Panel Objekt
        {
            get
            {
                if (m_Objekt == null)
                {
                    m_Objekt = new Panel
                    {
                        Size = new Size(30,30),
                        BackColor = Color.Red
                    };
                }
                m_Objekt.Location = Position;
                return m_Objekt;
            }
            
        }
    }
}
