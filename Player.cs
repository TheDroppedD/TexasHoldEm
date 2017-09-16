using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Timers;
namespace TexasHoldEm

{
    class Player{
        Hand Phand;
        int Chips = 500;


        Player(){
        }
        public void playerTurn(){
            //Timer, lights here
            Console.WriteLine("What is your move?");
            Console.WriteLine("ENTER 1 for Raise, ENTER 2 for Fold, ENTER 3 for Check ");
            string inp = Console.ReadLine();
            switch(inp){
                case "1":
                    Raise();
                    break;
                case "2":
                    Fold();
                    break;
                case "3":
                    Check();
                    break;

            }
        }
        public void Fold(){

        }
        public void Check(){

        }
        public void Raise(){

        }
        public void Pay(Player p1, int amount){
        }


    }
}