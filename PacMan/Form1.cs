using PacMan.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacMan
{
    public partial class Form1 : Form
    {
        private Random m_zufall = new Random();

        //BasicWall als Hindernis hinzzufügen. Vorher war das hindernis:
        // private List<Point> Walls = new List<Point>() 

        private List<BasicWall> TrueWalls = new List<BasicWall>() {
            new BasicWall()
            {
                Position = new Point (30, 270),
                Bild = Resources.pipeHori_SunTop
            },
            new BasicWall()
            {
                Position = new Point (30, 240),
                Bild = Resources.pipeVert_SunLeft
            },
            new BasicWall()
            {
                Position = new Point (30, 210),
                Bild = Resources.pipeEnd_Up
            },
            new BasicWall()
            {
                Position = new Point (30, 90),
                Bild = Resources.pipeVert_SunRight
            },
            new BasicWall()
            {
                Position = new Point (30, 60),
                Bild = Resources.pipeHori_SunTop
            },
            new BasicWall()
            {
                Position = new Point (60, 60),
                Bild = Resources.pipeHori_SunTop
            },
            new BasicWall()
            {
                Position = new Point (90, 60),
                Bild = Resources.pipeEnd_Right
            },
            new BasicWall()
            {
                Position = new Point (210, 60),
                Bild = Resources.pipeHori_SunTop
            },
            new BasicWall()
            {
                Position = new Point (240, 60),
                Bild = Resources.pipeHori_SunTop
            },
            new BasicWall()
            {
                Position = new Point (270, 60),
                Bild = Resources.pipeHori_SunTop
            },
            new BasicWall()
            {
                Position = new Point (210, 90),
                Bild = Resources.pipeVert_SunRight
            },
            new BasicWall()
            {
                Position = new Point (210, 120),
                Bild = Resources.pipeEnd_Down
            },
            new BasicWall()
            {
                Position = new Point (210, 240),
                Bild = Resources.pipeEnd_Right
            },
            new BasicWall()
            {
                Position = new Point (180, 240),
                Bild = Resources.pipeHori_SunTop
            },
            new BasicWall
            {
                Position = new Point (150, 240),
                Bild = Resources.pipeHori_SunTop
            },
            new BasicWall
            {
                Position = new Point (150, 270),
                Bild = Resources.pipeVert_SunLeft
            },
            new BasicWall
            {
                Position = new Point (120, 240),
                Bild = Resources.pipeHori_SunTop
            },
            new BasicWall
            {
                Position = new Point (120, 210),
                Bild = Resources.pipeVert_SunLeft
            },
            new BasicWall
            {
                Position = new Point (120, 180),
                Bild = Resources.pipeEnd_Up
            },
            new PortalWall()
            {
                Position = new Point (30, 120),
                Bild = Resources.pipeEnd_Right,
                isOpen = true,
                ÖffnungsRichtung = Richtung.rechts,
                Id = 0,
                IdOfTargetPortal = 1
            }

        };

        private List<Point> BasicWall = new List<Point>()           ///Kollision Hindernisse
        {
            
            new Point (120, 180),
            new Point (120, 210),
            new Point (120, 240),
            new Point (150, 270),
            new Point (150, 240),
            new Point (180, 240),
            new Point (210, 240),
            new Point (210, 120),
            new Point (210, 90),
            new Point (270, 60),
            new Point (240, 60),
            new Point (210, 60),
            new Point (90, 60),
            new Point (60, 60),
            new Point (30, 60),
            new Point (30, 90),
            new Point (30, 210),
            new Point (30, 240),
            new Point (30, 270)
        };
        

      ///  public class RohrO
      ///  {
      ///      public bool RohrOpen { get; set; }
      ///  }

        public Form1()
        {
            InitializeComponent();

        }
        private bool checkWalls(Point point)
        {
            if (BasicWall.Any(X => X == point))
            {
                return false;
            }
            return true;
        }
        ///Bewegungen Player1
        private void hochbtn_Click(object sender, EventArgs e)
        {
            var NP = new Point(player.Location.X, player.Location.Y - 30);
            if (NP.Y >= 0 && NP != player2.Location)
            {
                if (checkWalls(NP))
                {
                    player.Location = NP;
                    targetRefresh();
                }
            }
        }
        private void rechtsbtn_Click(object sender, EventArgs e)
        {
            var NP = new Point(player.Location.X + 30, player.Location.Y);
            if (NP.X <= 270 && NP != player2.Location)

            {
                if (checkWalls(NP))
                {
                    player.Location = NP;
                    targetRefresh();
                }
            }

        }
        private void runterbtn_Click(object sender, EventArgs e)
        {
            var NP = new Point(player.Location.X, player.Location.Y + 30);
            if (NP.Y <= 270 && NP != player2.Location)
            {
                if (checkWalls(NP))
                {
                    player.Location = NP;
                    targetRefresh();
                }
            }


        }
        private void linksbtn_Click(object sender, EventArgs e)
        {
            var NP = new Point(player.Location.X - 30, player.Location.Y);
            if (NP.X >= 0 && NP != player2.Location)
            {
                if (checkWalls(NP))
                {
                    player.Location = NP;
                    targetRefresh();
                }
            }

        }

        ///Kollision Spieler 1 und 2 mit Target
        private void targetRefresh()
        {
            if (player.Location == target.Location )
            {
                var message = "Treffer! Eine Tür hat sich geöffnet! Du kannst sie benutzen um ins nächste Level zu springen! Du musst sie nur suchen";
                MessageBox.Show(message);
            }
            else if (player2.Location == target.Location )
            {
                var message = "Treffer! Eine Tür hat sich geöffnet! Du kannst sie benutzen um ins nächste Level zu springen! Du musst sie nur suchen";
                MessageBox.Show(message);
            }

            ///Target St
            var O = false;
            var U = false;
            var L = false;
            var R = false;

            if (target.Location.Y - 30 >= 0)
            {
                O = true;
            }
            if (target.Location.Y + 30 <= 270)
            {
                U = true;
            }
            if (target.Location.X - 30 >= 0)
            {
                L = true;
            }
            if (target.Location.X + 30 <= 270)
            {
                R = true;
            }
            var wayFound = false;
            var count = 0;
            while (!wayFound && count < 3)
            {
                var X = m_zufall.Next(1, 5);
                switch (X)
                {
                    case 1:
                        count++;
                        if (O)
                        {
                            var NP = new Point(target.Location.X, target.Location.Y - 30);
                            if (NP != player.Location && checkWalls(NP) && NP != player2.Location)
                            {
                                target.Location = NP;
                                wayFound = true;
                            }
                        }
                        break;
                    case 2:
                        count++;
                        if (R)
                        {
                            var NP = new Point(target.Location.X + 30, target.Location.Y);
                            if (NP != player.Location && checkWalls(NP) && NP != player2.Location)
                            {

                                target.Location = NP;
                                wayFound = true;
                            }
                        }

                        break;
                    case 3:
                        count++;
                        if (U)
                        {
                            var NP = new Point(target.Location.X, target.Location.Y + 30);
                            if (NP != player.Location && checkWalls(NP) && NP != player2.Location)
                            {

                                target.Location = NP;
                                wayFound = true;
                            }
                        }
                        break;
                    case 4:
                        count++;
                        if (L)
                        {
                            var NP = new Point(target.Location.X - 30, target.Location.Y);
                            if (NP != player.Location && checkWalls(NP) && NP != player2.Location)
                            {

                                target.Location = NP;
                                wayFound = true;
                            }
                        }
                        break;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var NP = new Point(m_zufall.Next(1, 10) * 30, m_zufall.Next(1, 10) * 30);
            target.Location = NP;
        }

        private void playGround_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
            {
                hochbtn_Click(sender, new EventArgs());
            }
            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
            {
                runterbtn_Click(sender, new EventArgs());
            }
            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                rechtsbtn_Click(sender, new EventArgs());
            }

            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                linksbtn_Click(sender, new EventArgs());
            }
            if (e.KeyCode == Keys.U || e.KeyCode == Keys.Up)
            {
                hochbtn2_Click(sender, new EventArgs());
            }
            if (e.KeyCode == Keys.J || e.KeyCode == Keys.Down)
            {
                runterbtn2_Click(sender, new EventArgs());
            }
            if (e.KeyCode == Keys.K || e.KeyCode == Keys.Right)
            {
                rechtsbtn2_Click(sender, new EventArgs());
            }

            if (e.KeyCode == Keys.H || e.KeyCode == Keys.Left)
            {
                linksbtn2_Click(sender, new EventArgs());
            }
        }

        private void target_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel21_Paint(object sender, PaintEventArgs e)
        {

        }
        private void hochbtn2_Click(object sender, EventArgs e)
        {
            var NP = new Point(player2.Location.X, player2.Location.Y - 30);
            if (NP.Y >= 0 && NP != player.Location)

            {
                if (checkWalls(NP))
                {
                    player2.Location = NP;
                    targetRefresh();
                }
            }
        }

        
        private void rechtsbtn2_Click(object sender, EventArgs e)
        {
            var NP = new Point(player2.Location.X + 30, player2.Location.Y);
            if (NP.X <= 270 && NP != player.Location)

            {
                if (checkWalls(NP))
                {
                    player2.Location = NP;
                    targetRefresh();
                }
            }
 

        }

        private void runterbtn2_Click(object sender, EventArgs e)
        {
            var NP = new Point(player2.Location.X, player2.Location.Y + 30);
            if (NP.Y <= 270 && NP != player.Location)

            {
                if (checkWalls(NP))
                {
                    player2.Location = NP;
                    targetRefresh();
                }
            }
        }

        private void linksbtn2_Click(object sender, EventArgs e)
        {
            var NP = new Point(player2.Location.X - 30, player2.Location.Y);
            if (NP.X >= 0 && NP != player.Location)

            {
                if (checkWalls(NP))
                {
                    player2.Location = NP;
                    targetRefresh();
                }
            }

        }
        private void Form2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.U || e.KeyCode == Keys.Up)
            {
                hochbtn2_Click(sender, new EventArgs());
            }
            if (e.KeyCode == Keys.J || e.KeyCode == Keys.Down)
            {
                runterbtn2_Click(sender, new EventArgs());
            }
            if (e.KeyCode == Keys.K || e.KeyCode == Keys.Right)
            {
                rechtsbtn2_Click(sender, new EventArgs());
            }

            if (e.KeyCode == Keys.H || e.KeyCode == Keys.Left)
            {
                linksbtn2_Click(sender, new EventArgs());
            }
        }
        private void targetRefresh2()
        {
            if (player2.Location == target.Location)
            {
                var message = "Treffer! Eine Tür hat sich geöffnet! Du kannst sie benutzen um ins nächste Level zu springen! Du musst sie nur suchen";
                MessageBox.Show(message);
                
            }
        }


        ///private void item1Location()
        ///{
        /// if (player2.Location == Item1.Location)
        ///  {
        /// private void Form2_KeyUp(object sender, KeyEventArgs e)
        ///        {
        ///          if (e.KeyCode == Keys.U || e.KeyCode == Keys.Up)
        ///           {
        ///               hochbtn2_Click(sender, new EventArgs());
        ///            }
        ///            if (e.KeyCode == Keys.J || e.KeyCode == Keys.Down)
        ///            {
        ///               runterbtn2_Click(sender, new EventArgs());
        ///           }
        ///            if (e.KeyCode == Keys.K || e.KeyCode == Keys.Right)
        ///            {
        ///               rechtsbtn2_Click(sender, new EventArgs());
        ///            }
        ///          if (e.KeyCode == Keys.H || e.KeyCode == Keys.Left)
        ///          {
        ///              linksbtn2_Click(sender, new EventArgs());
        ///         }
        ///}
        ///}
        ///}

        private void target2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void playGround2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void newEntry() {

        }

        private void item1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    
}
