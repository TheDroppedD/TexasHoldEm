using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
namespace TexasHoldEm {
    class PokerDriver {

        static void Main(string[] args) {
            Console.WriteLine("Let's play a game of Poker!");
            Board game = new Board();
            game.playRound();
        } //rotation is repeated until people stop betting
    }
}