using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackMVC
{
    internal class Controller
    {
        private Deck Deck;
        public Hand PlayerHand;
        public Hand DealerHand;
        public Player Player { get; set; }
        public int Pot { get; set; }

        public bool BettingPhase;
        
        public bool GameOver;
        public String Result;

        public bool SplitActive;
        public Hand SplitHand;
        public int SplitPot {  get; set; }
        public bool SplitHold;



        public Controller() 
        {
            Deck = new Deck();
            PlayerHand = new Hand();
            DealerHand = new Hand();
            Player = new Player();
            Pot = 0;
            BettingPhase = true;
            GameOver = false;


            SplitActive = false;
            SplitHand = new Hand();
            SplitHold = false;


            Result = "";
        }

        public void StartGame()
        {
            BettingPhase = false;
            Deck.Shuffle();
            PlayerHand.addCard(Deck.DealCard());
            PlayerHand.addCard(Deck.DealCard());
            DealerHand.addCard(Deck.DealCard());
            if(PlayerHand.HandValue() == 21)
            {
                GameOver = true;
                DealerHand.addCard(Deck.DealCard());
                if(DealerHand.HandValue() == 21)
                {
                    Result = "PUSH";
                }
                else
                {
                    Result = "PLAYER WIN";
                    Player.wallet += Pot;
                    Pot = 0;
                }
            }
        }

        public void Hit() 
        {
            if (SplitActive) 
            { 
                SplitHand.addCard(Deck.DealCard());
                if(SplitHand.HandValue() == 21)
                {
                    Player.wallet += SplitPot;
                    SplitPot = 0;
                    SplitActive = false;
                    Result = "SPLIT HAND BLACKJACK";
                }
                else if(SplitHand.HandValue() > 21)
                {
                    Player.wallet -= SplitPot;
                    SplitPot = 0;
                    SplitActive = false;
                    Result = "SPLIT HAND BUST";
                }
            }
            else
            {
                PlayerHand.addCard(Deck.DealCard());
                if (PlayerHand.HandValue() == 21)
                {
                    GameOver = true;
                    Result = "PLAYER WINS";
                    Player.wallet += Pot;
                    Pot = 0;

                }
                else if (PlayerHand.HandValue() > 21)
                {
                    GameOver = true;
                    Result = "PLAYER BUST - DEALER WINS";
                    Player.wallet -= Pot;
                    Pot = 0;
                }
            }
            
        }
        public void Stand() 
        {
            if (SplitActive)
            {
                SplitActive = false;
                SplitHold = true;

            }
            else
            {
                GameOver = true;
                while (DealerHand.HandValue() < 17)
                {
                    DealerHand.addCard(Deck.DealCard());
                }
                EvaulateWinner();
            }
        }
        public void DoubleDown()
        {
            Pot *= 2;
        }

        public void EvaulateWinner() 
        { 
            if(PlayerHand.HandValue() > DealerHand.HandValue() || DealerHand.HandValue() > 21)
            {
                Result = "PLAYER WINS";
                Player.wallet += Pot;
                Pot = 0;
            }
            if(PlayerHand.HandValue() < DealerHand.HandValue() && DealerHand.HandValue()<=21)
            {
                Result = "DEALER WINS";
                Player.wallet -= Pot;
                Pot = 0;
            }
            if(PlayerHand.HandValue() == DealerHand.HandValue())
            {
                Result = "PUSH";
                
            }
            if (SplitHold)
            {
                if (SplitHand.HandValue() > DealerHand.HandValue() || DealerHand.HandValue() > 21)
                {
                    Result += "\nPLAYER WINS SPLIT HAND";
                    Player.wallet += SplitPot;
                    SplitPot = 0;
                }
                if (SplitHand.HandValue() < DealerHand.HandValue() && DealerHand.HandValue() <= 21)
                {
                    Result += "\nDEALER WINS SPLIT HAND";
                    Player.wallet -= SplitPot;
                    SplitPot = 0;
                }
                if (SplitHand.HandValue() == DealerHand.HandValue())
                {
                    Result += "\nPUSH ON SPLIT HAND";
                    Pot += SplitPot;

                }
            }
        }

        public void Split() 
        {
            SplitHand.addCard(PlayerHand.removeCard());
            SplitPot = Pot;
            PlayerHand.addCard(Deck.DealCard());
            SplitHand.addCard(Deck.DealCard());
            SplitActive = true;
        }

        public void Reset() 
        {
            PlayerHand = new Hand();
            DealerHand = new Hand();
            BettingPhase = true;
            GameOver = false;
            Result = "";
            SplitActive = false;
            SplitHold = false;
            SplitHand = new Hand();
        }

        public string GetPlayerHandString()
        {
            return PlayerHand.returnHand();
        }
        public string GetDealerHandString()
        {
            return DealerHand.returnHand();
        }
        public string GetSplitHandString()
        {
            return SplitHand.returnHand();
        }


    }
}
