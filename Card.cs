using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLowCard
{
    class Card
    {
        private int _suit;
        private int _rank;

        protected string[] suit = { "Clubs", "Diamonds", "Hearts", "Spades" };
        protected string[] rank = { "Ace", "Deuce", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };

        public int Rank
        {
            get
            {
                return _rank;
            }

            set
            {
                _rank = value;
            }
        }

        public int Suit
        {
            get
            {
                return _suit;
            }

            set
            {
                _suit = value;
            }
        }

        public Card()
        {
            Rank = 0;
            Suit = 0;
        }

        public Card(int x, int y)
        {
            Rank = x;
            Suit = y;
        }

        public override string ToString()
        {
            return string.Format("rank={0} suit={1} ", _rank, _suit);
        }
    }
}
