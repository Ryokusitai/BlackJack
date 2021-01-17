using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    /// <summary>
    /// 一枚のトランプカード
    /// </summary>
    internal class Card
    {
        public int Value { get; }

        public Card(int value)
        {
            this.Value = value;
        }
    }
}