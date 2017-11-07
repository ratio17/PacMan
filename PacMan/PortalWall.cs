namespace PacMan
{
    public class PortalWall:BasicWall
    {
        public int Id { get; set; }

        public bool isOpen { get; set; }

        public Richtung ÖffnungsRichtung { get; set; }

        public int IdOfTargetPortal { get; set; }
    }
}
