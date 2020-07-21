using System.Windows.Forms;

namespace ElephantRace
{
    public class Joe : Punter
    {
        public Joe(Bet bet, Label MaximumBet, int Cash, Label label) : base(bet, MaximumBet, Cash, label)
        {
        }

        public override void setPunterName()
        {
            Name = "Joe";
        }
    }
}
