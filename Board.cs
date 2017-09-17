using System;
using System.Collections.Generic;

namespace TexasHoldEm{
   
   class Board : IComparer<Player>{
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
        aDeck = new Deck();
        Commcards = new Hand(); //empty hand
        Players = new List<Player>(4); //4 players including user
        Jackpot = 0; 
        Currentbet = 5; 
        //this.Numrounds = Numrounds;
        playersInRound = Players;
    }

    public void startGame() {
        //Deck is shuffled
        Console.WriteLine("Shuffling Deck"); 
        aDeck.shuffleDeck();
        //Players are given cards
        Console.WriteLine("Ante Up!"); 
        anteUp();
        Console.WriteLine("Dealing Cards"); 
        foreach(Player p in playersInRound) {
            //add card to Player's Phand
            p.getPhand().add(aDeck.drawCard());
            p.getPhand().add(aDeck.drawCard());
        }
        Console.WriteLine("Cards Dealt"); 
    }//done

    public void dealCard(int numCards){
       for(int i = 0; i < numCards; i++){
           Card c = aDeck.drawCard();
           Commcards.add(c);
           foreach(Player p in playersInRound) {
               p.getPhand().add(c);
           }
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
        Console.WriteLine("Inside Ante Up"); 
        foreach(Player p in playersInRound) {
            //if p agrees to pay
            if(p.anteU()) {
            Jackpot += p.Pay(Currentbet);
            } else {
            playersInRound.Remove(p);
        }
    }
}//done
    public void playRound(){
        Console.WriteLine("Game will now start");
        startGame();
        Console.WriteLine("Rotation Starting");
        rotation();
        Console.WriteLine("Flop is Dealt");
        dealCard(TheFlop);
        Console.WriteLine("Rotation Starting");
        rotation();
        Console.WriteLine("The Run is Dealt");
        dealCard(TheRun);
        Console.WriteLine("Rotation Starting");
        rotation();
        Console.WriteLine("The River is Dealt");
        dealCard(TheRiver);
        Console.WriteLine("Rotation Starting");
        rotation();
        Console.WriteLine("Show Down starting");
        showDown(); //FIN
    }
    public void addJackpot(int money) {
        Jackpot += money;
    }

    public void addCurrentBet(int money) {
        Currentbet += money;
    }
    public void showDown(){
        playersInRound.Sort(Compare); //sorts players by hands
    }

    
         public int Compare(Player x, Player y) { //Compare Distinct Score
            if(x.getPhand().getDistinctScore() > y.getPhand().getDistinctScore()) {
                return -1;
            } else if(x.getPhand().getDistinctScore() < y.getPhand().getDistinctScore()) {
                return 1;
            } else {
                return 0;
            }
        }//Done


   }//Board
}//Texasholdem