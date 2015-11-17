using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLowCard
{
    class Player
    {
        private Deck _playedDeck;
        private Deck _count;
        private string _name;

        public Deck PlayedDeck
        {
            get
            {
                return _playedDeck;
            }

            set
            {
                _playedDeck = value;
            }
        }

        public Deck Count
        {
            get
            {
                return _count;
            }

            set
            {
                _count = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public Player()
        {
            Name = "Unknown";
            PlayedDeck = new Deck();
            Count = new Deck();
        }
    }
}
