using System;
using System.Drawing;
using System.Windows.Forms;

namespace ElephantRace
{
    public class Elephant
    {
        private static int StartingPosition;
        private static int RacetrackLength;
        public PictureBox LionPictureBox = null;
        public int Location = 0;
        public static Random MyRandom = new Random(); //declared random object as static to avoid same random number

        public static int StartingPosition1 { get => StartingPosition; set => StartingPosition = value; }
        public static int RacetrackLength1 { get => RacetrackLength; set => RacetrackLength = value; }

        // generation across all Lion objects

        public static bool Run(Elephant obj)
        {
            int distance = MyRandom.Next(2, 6);
            if (obj.LionPictureBox != null)
                obj.MoveLionPictureBox(distance);

            obj.Location += distance;
            if (obj.Location >= (RacetrackLength1 - StartingPosition1))
            {
                return true;
            }
            return false;
        }

        public void TakeStartingPosition()
        {
            MoveLionPictureBox(-Location); //reset location to -ve distance ie. to starting point
            Location = 0;

        }

        public void MoveLionPictureBox(int distance)
        {
            Point p = LionPictureBox.Location;
            p.X += distance;
            LionPictureBox.Location = p; //move Lion in x-axis
        }
    }
}
