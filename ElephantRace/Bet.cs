using System;

namespace ElephantRace
{
    public class Bet
    {
        public int Amount;
        public int LionNum;
        public Punter Bettor;

        public Bet(int Amount, int LionNum, Punter Bettor)
        {
            this.Amount = Amount;
            this.LionNum = LionNum;
            this.Bettor = Bettor;
        }

        public string GetDescription()
        {
            string description = "";

            if (Amount > 0)
            {
                description = String.Format("{0} bets {1} on Lion #{2}",
                    Bettor.Name, Amount, LionNum);
            }
            else
            {
                description = String.Format("{0} hasn't placed any bets",
                    Bettor.Name);
            }
            return description;
        }

        public int Pay(int Winner)
        {
            if (LionNum == Winner)
            {
                return Amount;
            }
            return -Amount;
        }
    }
}
