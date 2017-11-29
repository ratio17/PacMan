using PacMan.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//182100
namespace PacMan
    
{
    public partial class Form1 : Form
    {
        private Random m_zufall = new Random();

        //TrueWalls als Hindernis hinzufügen. Vorher war das hindernis:                                 (siehe Liste:  BasicWall (Z. 140))
         //private List<Point> Walls = new List<Point>()

        private List<BasicWall> TrueWalls = new List<BasicWall>()
        { 
            new BasicWall()
            {
                Position = new Point (30, 270),
                Bild = Resources.pipeVert_SunLeft
            },
            new BasicWall()
            {
                Position = new Point (30, 240),
                Bild = Resources.pipeVert_SunLeft
            },
            new PortalWall()
            {
                Position = new Point (30, 210),
                Bild = Resources.pipeEnd_Up,
                isOpen = true,
                ÖffnungsRichtung = Richtung.oben,
                Id = 4,
                IdOfTargetPortal = 2
            },
            new BasicWall()
            {
                Position = new Point (30, 90),
                Bild = Resources.pipeVert_SunLeft
            },
            new BasicWall()
            {
                Position = new Point (30, 60),
                Bild = Resources.pipeRund_SonneObenLinks
            },
            new BasicWall()
            {
                Position = new Point (60, 60),
                Bild = Resources.pipeHori_SunTop     
            },
            new PortalWall()
            {
                Position = new Point (90, 60),
                Bild = Resources.pipeEnd_Right,
                isOpen = true,
                ÖffnungsRichtung = Richtung.rechts,
                Id = 1,
                IdOfTargetPortal = 3
            },
            new BasicWall()
            {
                Position = new Point (210, 60),
                Bild = Resources.pipeRund_SonneObenLinks
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
                Bild = Resources.pipeVert_SunLeft
            },
            new BasicWall()
            {
                Position = new Point(210, 270),
                Bild = Resources.pipeVert_SunLeft
            },
            new PortalWall()
            {
                Position = new Point (210, 120),
                Bild = Resources.pipeEnd_Down,
                isOpen = false,
                ÖffnungsRichtung = Richtung.unten,
                Id = 0,
                IdOfTargetPortal = 1
            },
            new BasicWall()
            {
                Position = new Point (210, 240),
                Bild = Resources.pipeRund_SonneUntenLinks
            },
            new BasicWall()
            {
                Position = new Point (180, 240),
                Bild = Resources.pipeHori_SunBot
            },
            new BasicWall()
            {
                Position = new Point (150, 240),
                Bild = Resources.pipeHori_SunBot
            },
            new BasicWall()
            {
                Position = new Point (120, 240),
                Bild = Resources.pipeRund_SonneUntenObenLinks
            },
            new BasicWall()
            {
                Position = new Point (120, 210),
                Bild = Resources.pipeVert_SunLeft
            },
            new PortalWall()
            {
                Position = new Point (120, 180),
                Bild = Resources.pipeEnd_Up,
                isOpen = true,
                ÖffnungsRichtung = Richtung.oben,
                Id = 2,
                IdOfTargetPortal = 4

            },
            new PortalWall()
            {
                Position = new Point (30, 120),
                Bild = Resources.pipeEnd_Down,
                isOpen = true,
                ÖffnungsRichtung = Richtung.unten,
                Id = 3,
                IdOfTargetPortal = 1

            }
            
        };

        public Form1()
        {
            InitializeComponent();
            foreach (BasicWall basicWall in TrueWalls)
            {
                var panel = new Panel()
                {
                    Location = basicWall.Position,
                    BackgroundImage = basicWall.Bild,
                    Size = new Size(30,30)
                };
                playGround.Controls.Add(panel);
            }
            playGround.Refresh();
        }

        private Richtung getRichtung(Point oldPoint, Point newPoint)
        {
            if (oldPoint.X != newPoint.X)
            {
                if (oldPoint.X < newPoint.X)
                {
                    return Richtung.links;          //Spieler kommt von links ins nächste Feld
                }
                else
                {
                    return Richtung.rechts;         // Spieler kommt von rechts ins nächste Feld
                }
            }
            else
            {
                if (oldPoint.Y > newPoint.Y)
                {
                    return Richtung.unten;          //Spieler kommt von unten ins nächste Feld
                }
                else
                {
                    return Richtung.oben;           //Spieler Kommt von oben ins nächste Feld
                }
            }
        }

        private bool checkWalls(ref Point point, Point oldPoint)
        {
            var p = point;
            if (TrueWalls.Any(X => X.Position == p))
            {
                var Wall = TrueWalls.First(X => X.Position == p) as PortalWall;
                
                if (Wall != null && Wall.isOpen)
                {
                    var playerRichtung = getRichtung(oldPoint, point);
                    if (Wall.ÖffnungsRichtung == playerRichtung)
                    {
                        var zielPortal = TrueWalls.Where(x => x is PortalWall).Cast<PortalWall>()
                            .First(x => x.Id == Wall.IdOfTargetPortal);
                        point = zielPortal.Position;
                        switch (zielPortal.ÖffnungsRichtung)
                        {
                            case Richtung.links:
                                point.X -= 30;
                                break;
                            case Richtung.rechts:
                                point.X += 30;
                                break;
                            case Richtung.oben:
                                point.Y -= 30;
                                break;
                            case Richtung.unten:
                                point.Y += 30;
                                break;
                        }
                        return true;
                    }
                }
               
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
                if (checkWalls(ref NP, player.Location))
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
                if (checkWalls(ref NP, player.Location))
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
                if (checkWalls(ref NP, player.Location))
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
                if (checkWalls(ref NP, player.Location))
                {
                    player.Location = NP;
                    targetRefresh();
                }
            }

        }
        //sobald die röhre begangen wird und die pfeilstaste nach oben betätigt, wird man TP´t
       
        ///Kollision Spieler 1 und 2 mit Target
        private void targetRefresh()
        {
            if (player.Location == target.Location )
            {
                var message = "Treffer! Eine Tür hat sich geöffnet! Du kannst sie benutzen um ins nächste Level zu springen! Du musst sie nur suchen";
                MessageBox.Show(message);
                playGround.BackgroundImage = Resources.Backcolor2;
                //this.BackgroundImage = new Bitmap(@"C:\Users\FinkA\Pictures\Saved Pictures\retro-fernseher.jpg");

                //Hier muss hinzugefügt werden, dass sich eine "Tür" öffnet, sobald der Geist in LVL 1 geschnappt wurde (PortalWall öffnet sich)
            }
            else if (player2.Location == target.Location )
            {
                var message = "Treffer! Eine Tür hat sich geöffnet! Du kannst sie benutzen um ins nächste Level zu springen! Du musst sie nur suchen";
                MessageBox.Show(message);
                playGround.BackgroundImage = Resources.Background3;

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
            while (!wayFound && count < 100)
            {
                var X = m_zufall.Next(1, 5);
                switch (X)
                {
                    case 1:
                        count++;
                        if (O)
                        {
                            var NP = new Point(target.Location.X, target.Location.Y - 30);
                            if (NP != player.Location && checkWalls(ref NP, target.Location) && NP != player2.Location)
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
                            if (NP != player.Location && checkWalls(ref NP, target.Location) && NP != player2.Location)
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
                            if (NP != player.Location && checkWalls(ref NP, target.Location) && NP != player2.Location)
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
                            if (NP != player.Location && checkWalls(ref NP, target.Location) && NP != player2.Location)
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
            if (e.KeyCode == Keys.W )
            {
                hochbtn_Click(sender, new EventArgs());
            }
            if (e.KeyCode == Keys.S )
            {
                runterbtn_Click(sender, new EventArgs());
            }
            if (e.KeyCode == Keys.D )
            {
                rechtsbtn_Click(sender, new EventArgs());
            }
            if (e.KeyCode == Keys.A )
            {
                linksbtn_Click(sender, new EventArgs());
            }
            if (e.KeyCode == Keys.Up)
            {
                hochbtn2_Click(sender, new EventArgs());
            }
            if (e.KeyCode == Keys.Down)
            {
                runterbtn2_Click(sender, new EventArgs());
            }
            if (e.KeyCode == Keys.Right)
            {
                rechtsbtn2_Click(sender, new EventArgs());
            }

            if (e.KeyCode == Keys.Left)
            {
                linksbtn2_Click(sender, new EventArgs());
            }
        }
        //all diese EventArgs müssen bereinigt werden.
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
                if (checkWalls(ref NP, player2.Location))
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
                if (checkWalls(ref NP, player2.Location))
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
                if (checkWalls(ref NP, player2.Location))
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
                if (checkWalls(ref NP, player2.Location))
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
            if ( e.KeyCode == Keys.Up)
            {
                hochbtn2_Click(sender, new EventArgs());
            }
            if ( e.KeyCode == Keys.Down)
            {
                runterbtn2_Click(sender, new EventArgs());
            }
            if ( e.KeyCode == Keys.Right)
            {
                rechtsbtn2_Click(sender, new EventArgs());
            }

            if ( e.KeyCode == Keys.Left)
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
        
        private void target2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void playGround2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void newEntry()
        {

        }

        private void item1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
