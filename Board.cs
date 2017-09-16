using System;
using System.Collections.Generic;

namespace TexasHoldEm{
   
   class Board{
    private Hand Commcards;
    private List<Player> Players;
    private int Moneypot;
    private int Currentbet;
    private int Numrounds;
    private List<Player> playersInRound;

    public Board(Hand Commcards, List<Player> Players, int Moneypot, int Currentbet, int Numrounds, List<Player> playersInRound) {
        this.Commcards = Commcards;
        this.Players = Players;
        this.Moneypot = Moneypot;
        this.Currentbet = Currentbet;
        this.Numrounds = Numrounds;
        this.playersInRound = playersInRound;
    }

    public void addMoneyPot(int money) {
        Moneypot += money;
    }

    public void addCurrentBet(int money) {
        Currentbet += money;
    }

   }//Board
}//Texasholdem