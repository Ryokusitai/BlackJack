using BlackJack.Person;
using System;
using System.Linq;

namespace BlackJack
{
    /// <summary>
    /// メインクラス
    /// 実際のゲーム(ブラックジャック)の処理
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            var me = new Player();
            var game = new BlackJack(me);
            game.Start();

            // プレイヤーの操作
            while (me.Hand.Sum(card => card.Value) <= 16)
            {
                game.Hit(me);
            }

            // 結果
            game.OpenHand();
            Console.WriteLine(game.GetResult(me));
            // 一応プレイヤーの手札も表示しとく
            Console.Write(string.Join(',', me.Hand.Select(card => card.Value)));
        }
    }
}