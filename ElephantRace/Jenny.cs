using System.Windows.Forms;

namespace ElephantRace
{
    public class Jenny : Punter
    {
        public Jenny(Bet bet, Label MaximumBet, int Cash, Label label) : base(bet, MaximumBet, Cash, label)
        {
        }

        public override void setPunterName()
        {
            Name = "Jenny";
        }
    }
}
