using System;
using System.Windows.Forms;

namespace ElephantRace
{
    public class Factory
    {
        public Punter getPunter(String Name, Label MaximumBet, Label bet)
        {
            Punter p;
            switch (Name.ToLower())
            {
                case "al":
                    p = new Al(null, MaximumBet, 50, bet);
                    break;

                case "jenny":
                    p = new Jenny(null, MaximumBet, 50, bet);
                    break;

                case "joe":
                    p = new Joe(null, MaximumBet, 50, bet);
                    break;

                default:
                    p = null;
                    break;
            }
            p.setPunterName();
            return p;
        }
    }
}
