using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    /// <summary>
    /// トランプ全体
    /// 今回は52枚(ジョーカーを含まない)
    /// </summary>
    internal class Trump
    {
        public List<Card> Cards { get; }

        public int Count
        {
            get
            {
                return this.Cards.Count;
            }
        }

        public Trump()
        {
            this.Cards = new List<Card>();
            for (var i = 0; i < 4; i++)
            {
                for (var value = 1; value <= 13; value++)
                {
                    Cards.Add(new Card(value));
                }
            }
        }
    }
}