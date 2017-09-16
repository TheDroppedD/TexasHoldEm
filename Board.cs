using System;
using System.Collections.Generic;

namespace TexasHoldEm{
   
   class Board{
    private Deck aDeck;
    private Hand Commcards;
    private List<Player> Players;
    private int Jackpot;
    private int Currentbet;
    //private int Numrounds;
    private List<Player> playersInRound;
    private Boolean inBet = false;
    private readonly int TheFlop = 3;
    private readonly int TheRun = 1;
    private readonly int TheRiver = 1; 

    public Board() {
        Deck aDeck = new Deck();
        Commcards = new Hand(); //empty hand
        Players = new List<Player>(4); //4 players including user
        Jackpot = 0; 
        Currentbet = 5; 
        //this.Numrounds = Numrounds;
        playersInRound = Players;
    }

    public void startGame() {
        //Deck is shuffled
        aDeck.shuffleDeck();
        //Players are given cards
        anteUp();
        foreach(Player p in playersInRound) {
            //add card to Player's Phand
            p.getPhand().add(aDeck.drawCard());
            p.getPhand().add(aDeck.drawCard());
        }
    }//done

    public void dealCard(int numCards){
       for(int i = 0; i < numCards; i++){
           Commcards.add(aDeck.drawCard());
       }
    }

    public void rotation() {
        int count = 0; //Number of turns made
        while(count != playersInRound.Count){
            foreach(Player p in playersInRound) {
            //exception where if player raises, re do rotation()
            int n = p.playerTurn(inBet);
            count += 1;
            switch(n) {
                case 1: //Raise
                    int amount = p.Raise();
                    Currentbet += amount;
                    Jackpot+=amount; 
                    inBet = true;
                    rotation();
                    break;
                case 2: //Fold
                    playersInRound.Remove(p);
                    break;
                case 3: //Call
                    //player function call is called
                    amount = Currentbet - p.getAmountPaid();
                    Jackpot +=p.Pay(amount);
                    break;
                case 4: //Check
                    break;
            }
        }
    }
}//done

    public void anteUp() {
        //Players to bet
        foreach(Player p in playersInRound) {
            //if p agrees to pay
            if(p.anteUp()) {
            Jackpot += p.Pay(Currentbet);
            } else {
            playersInRound.Remove(p);
        }
    }
}//done
    public void playRound(){
        startGame();
        rotation();
        dealCard(TheFlop);
        rotation();
        dealCard(TheRun);
        rotation();
        dealCard(TheRiver);
    }
    public void addJackpot(int money) {
        Jackpot += money;
    }

    public void addCurrentBet(int money) {
        Currentbet += money;
    }
    public void showDown(){
        foreach(Player p in playersInRound){
            
        }
    }

   }//Board
}//Texasholdem