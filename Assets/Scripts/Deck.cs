using UnityEngine;

public class Deck {
    public Card[,] _cards;

    public int NUM_SUITS = System.Enum.GetValues(typeof(Suit)).Length;
    public int NUM_VALUES = System.Enum.GetValues(typeof(Value)).Length;

    public Deck (Sprite[] cardSprites){
        this._cards = new Card[NUM_SUITS, NUM_VALUES];
        Suit[] suits = (Suit[]) System.Enum.GetValues(typeof(Suit));
        Value[] values = (Value[]) System.Enum.GetValues(typeof(Value));
        int spriteCount = 0;
        
        for (int suitIndex = 0; suitIndex < NUM_SUITS; suitIndex++) {
            Suit suit = suits[suitIndex];
            for (int valueIndex = 0; valueIndex < NUM_VALUES; valueIndex++) {
                Value value = values[valueIndex];
                this._cards[suitIndex, valueIndex] = new Card(suit, value, cardSprites[spriteCount]);
                spriteCount += 1;
            }
        }
    }

    public Deck (Card[,] cards){
        this._cards = cards;
    }

    public Card[] dealCards(int numberOfCards){
        Card[] cards = new Card[numberOfCards];

        for (int i = 0; i < NUM_SUITS; i++) {
            for (int j = 0; j < NUM_VALUES; j++) {
                if(numberOfCards == 0) return cards;
                if(!_cards[i, j]._withdrew){
                    cards[numberOfCards - 1] = _cards[i, j];
                    _cards[i, j]._withdrew = true;
                    numberOfCards -= 1;
                } 
            }
        }
        return cards;
    }

    public void resetDeck(){
        for (int i = 0; i < NUM_SUITS; i++) {
            for (int j = 0; j < NUM_VALUES; j++) {
                _cards[i, j]._withdrew = false; 
            }
        }
    }

    private void printDeck(string message){
        int NUM_SUITS = System.Enum.GetValues(typeof(Suit)).Length;
        int NUM_VALUES = System.Enum.GetValues(typeof(Value)).Length;
        
        for (int suitIndex = 0; suitIndex < NUM_SUITS; suitIndex++) {
            for (int valueIndex = 0; valueIndex < NUM_VALUES; valueIndex++) {
                Debug.Log(message + " " + this._cards[suitIndex, valueIndex]._value);
                Debug.Log(message + " " + this._cards[suitIndex, valueIndex]._suit);
            }
        }
    }
}