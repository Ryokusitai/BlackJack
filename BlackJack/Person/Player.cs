using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack.Person
{
    internal class Player
    {
        public List<Card> Hand { get; }

        public Player()
        {
            this.Hand = new List<Card>();
        }

        public void ClearHand()
        {
            this.Hand.Clear();
        }
    }
}