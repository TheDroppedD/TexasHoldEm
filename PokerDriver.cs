using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
namespace TexasHoldEm 
{
    class PokerDriver
    {

        static void Main(string[] args) { //init
            Console.WriteLine("Let's play a game of Poker!");
            Console.Write("How many players would you like? ");
            string s = Console.ReadLine();
            int playernum = Convert.ToInt32(s); //number of players
            Console.WriteLine(playernum);
            Board game = new Board(playernum); //Game Class
            game.playRound(); //Game Method
        } //rotation is repeated until people stop betting
    }
}