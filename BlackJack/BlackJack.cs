using BlackJack.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack
{
    /// <summary>
    /// プレイヤーの手札の操作
    /// ディーラーの操作
    /// 勝敗計算
    /// 等を行う
    /// </summary>
    internal class BlackJack
    {
        private Dealer dealer;
        private Player player1;

        /// <summary>
        /// 今回は1対1なので参加プレイヤー1人を引数に取る
        /// </summary>
        /// <param name=""></param>
        public BlackJack(Player player)
        {
            // ディーラーの準備
            this.dealer = new Dealer();
            // 参加者の登録
            this.player1 = player;
        }

        public void Start()
        {
            // トランプの初期化
            this.dealer.OpenNewTrump();
            // 手札の初期化
            this.dealer.ClearHand();
            this.player1.ClearHand();
            // お互い2枚引く
            this.dealer.Deal(2, this.dealer);
            this.dealer.Deal(2, player1);
        }

        /// <summary>
        /// 引数で指定したプレイヤーの手札に一枚加える
        /// </summary>
        /// <param name="player"></param>
        public void Hit(Player player)
        {
            this.dealer.Deal(1, player);
        }

        /// <summary>
        /// 勝負
        /// </summary>
        public void OpenHand()
        {
            // ディーラーはまだカードを引いていないのでここでカードを引く
            while (this.dealer.Hand.Sum(card => card.Value) <= 16)
            {
                this.Hit(this.dealer);
            }
        }

        public string GetResult(Player player)
        {
            int dealerSum = this.dealer.Hand.Sum(card => card.Value);
            int sum = player.Hand.Sum(card => card.Value);
            var scoreDetail = " player:" + sum + "/ dealer:" + dealerSum;
            var result = "";
            if (sum > 21)
            {
                result = "バースト(負け)";
            }
            else if (dealerSum > 21 || sum > dealerSum)
            {
                result = "勝ち";
            }
            else if (sum == dealerSum)
            {
                result = "引き分け";
            }
            else
            {
                result = "負け";
            }
            return result + scoreDetail;
        }
    }
}