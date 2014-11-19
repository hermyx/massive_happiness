using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class Game : IGame
    {
        public IList<IPlayer> _players
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public IBoard _board
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public int _currentPlayer
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void addPlayer(String name, int points)
        {
            throw new NotImplementedException();
        }

        public bool hasWinner()
        { // Two possibilities : One player is the only one who have units 
            //or the number of turn is exhausted: highest score wins
            throw new NotImplementedException();
        }
    }
}
