using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack.Person
{
    /// <summary>
    /// ディーラー
    /// カードを配ったりする
    /// </summary>
    internal class Dealer : Player
    {
        private Trump trump;
        private Random random;

        public void OpenNewTrump()
        {
            this.trump = new Trump();
            this.random = new Random();
        }

        /// <summary>
        /// カードを配る
        /// </summary>
        /// <param name="num">配る枚数</param>
        /// <param name="player">配る対象</param>
        public void Deal(int num, Player player)
        {
            for (int i = 0; i < num; i++)
            {
                player.Hand.Add(this.PickOne());
            }
        }

        /// <summary>
        /// ランダムに一枚カードを引く
        /// </summary>
        /// <returns></returns>
        public Card PickOne()
        {
            // TODO:カード(山札)がないならエラー
            var index = this.random.Next(0, this.trump.Count);
            var pickCard = this.trump.Cards[index];
            this.trump.Cards.RemoveAt(index);
            return pickCard;
        }
    }
}