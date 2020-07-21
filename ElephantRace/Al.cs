using System.Windows.Forms;

namespace ElephantRace
{
    public class Al : Punter
    {
        public Al(Bet MyBet, Label MaximumBet, int Cash, Label MyLabel) : base(MyBet, MaximumBet, Cash, MyLabel)
        {
        }

        public override void setPunterName()
        {
            Name = "Al";
        }
    }
}
