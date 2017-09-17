using System;
using System.Collections.Generic;
using System.Threading;

namespace TexasHoldEm
{
   
   class Board : IComparer<Player>
   {
    private Deck aDeck;
    private Hand Commcards;
    private List<Player> Players = new List<Player>();
    private List<Player> cPlayers = new List<Player>(); //current players
    private int currentPlayers; //initialized in constructor
    public int playerSize;
    private int Jackpot;
    private int Currentbet;
    //private int Numrounds;
    //private List<Player> Players = new List<Player>();
    //Perhaps I could declare an int currentPlayers that bumps up by one 
    //according to some research, using 
    public Boolean inBet = false;
    private readonly int TheFlop = 3;
    private readonly int TheRun = 1;
    private readonly int TheRiver = 1;

    public Board(int playerNum) 
    {
        aDeck = new Deck();
        Commcards = new Hand(); //empty hand
        Players = new List<Player>(playerSize); //4 players including user
        currentPlayers = playerSize = playerNum; //sets number of players in the game
        for(int i = 0; i < playerSize; i++) 
        { 
            //Fills array with Player objects up to the number of players
            Player p = new Player();
            Players.Add(p);
            cPlayers.Add(p);
        }
        Jackpot = 0; 
        Currentbet = 5; 
        //this.Numrounds = Numrounds;
    }

    //Getters and Setters
    public Deck getDeck() 
    {
        return aDeck;
    }

    public void setDeck(Deck d) 
    {
        aDeck = d;
    }

    public Hand getCommcards() 
    {
        return Commcards;
    }
    public void setCommcards(Hand h) 
    {
        Commcards = h;
    }

    public List<Player> getPlayers() 
    {
        return Players;
    }

    public void setJackpot(int n) 
    {
        Jackpot = n;
    }

    public int getJackpot() 
    {
        return Jackpot;
    }

    public void setCurrentbet(int n) 
    {
        Currentbet = n;
    }

    public int getCurrentbet() 
    {
        return Currentbet;
    }

     public void addJackpot(int money)
    {
        Jackpot += money;
    }

    public void addCurrentBet(int money) 
    {
        Currentbet += money;
    }




    public void startGame() 
    {
        //Deck is shuffled
        Console.WriteLine("Shuffling Deck"); 
        Thread.Sleep(1000); //potential tool instead of spamming space
        aDeck.shuffleDeck();
        //Players are given cards
        Console.WriteLine("Ante Up!"); 
        Thread.Sleep(1000);
        anteUp();
        Console.WriteLine("Dealing Cards"); 
        Thread.Sleep(1000);
        foreach(Player p in cPlayers) 
        {
            //adds two cards to Player's Phand
            p.getPhand().add(aDeck.drawCard());
            p.getPhand().add(aDeck.drawCard());
        }
        //Players[0].isHuman = true;
        Console.WriteLine("Cards Dealt"); 
        Thread.Sleep(1000);
    }//Done

    public void dealCard(int numCards)
    {
        Console.WriteLine("Dealing Card"); 
        Thread.Sleep(1000);
       for(int i = 0; i < numCards; i++)
       {
           Card c = aDeck.drawCard();
           Commcards.add(c); //adds c to community
           foreach(Player p in cPlayers) 
           {
               p.getPhand().add(c);
           }
       }
    }//Done

     public int Compare(Player x, Player y) 
         { //Compare Distinct Score
            if(x.getPhand().getDistinctScore() > y.getPhand().getDistinctScore()) 
            {
                return -1;
            } 
            else if(x.getPhand().getDistinctScore() < y.getPhand().getDistinctScore()) 
            {
                return 1;
            } 
            else 
            {
                return 0;
            }
        }//Done

    public void rotation() 
    {
        int count = 0; //Number of turns made
        //Console.WriteLine(Players.Count);
        while(count != cPlayers.Count) //?
        {
            for(int i = currentPlayers - 1; i > -1; i--) 
            {
            //exception where if player raises, re do rotation()
            int n = Players[i].playerTurn(inBet);
            count += 1;
            switch(n) 
            {
                case 1: //Raise
                    int amount = cPlayers[i].Raise();
                    Currentbet += amount;
                    Jackpot+=amount; 
                    inBet = true;
                    rotation(); //Calls rotation again because a new round is being done
                    break;
                case 2: //Fold
                //A player that Folds is no longer needed in the game
                    Players.RemoveAt(i); 
                    break;
                case 3: //Call
                    //player function call is called
                    amount = Currentbet - cPlayers[i].getAmountPaid();
                    Jackpot += cPlayers[i].Pay(amount);
                    break;
                case 4: //Check
                //Nothing Happens
                    break;
            }
        }
    }
}//Done

    public void anteUp() 
    {
        //Players to bet
        for(int i = currentPlayers - 1; i > -1; i--) 
        {
            //if p agrees to pay
            Boolean booling = cPlayers[i].anteU();
            if(booling) 
            {
            Jackpot += cPlayers[i].Pay(Currentbet);
            } 
            else 
            {
            cPlayers.RemoveAt(i);
        }
    }
}//done
    public void playRound()
    {
        Console.WriteLine("Game will now start");
        Thread.Sleep(1000);
        startGame();
        Console.WriteLine("Rotation Starting");
        Thread.Sleep(1000);
        rotation();
        Console.WriteLine("Flop is Dealt");
        Thread.Sleep(1000);
        dealCard(TheFlop);
        Console.WriteLine("Rotation Starting");
        Thread.Sleep(1000);
        rotation();
        Console.WriteLine("The Run is Dealt");
        Thread.Sleep(1000);
        dealCard(TheRun);
        Console.WriteLine("Rotation Starting");
        Thread.Sleep(1000);
        rotation();
        Console.WriteLine("The River is Dealt");
        Thread.Sleep(1000);
        dealCard(TheRiver);
        Console.WriteLine("Rotation Starting");
        Thread.Sleep(1000);
        rotation();
        Console.WriteLine("Show Down starting");
        Thread.Sleep(1000);
        showDown(); //FIN
    }

    public void showDown()
    {
        Players.Sort(Compare); //sorts players by hands
    }

   }//Board
}//Texasholdem