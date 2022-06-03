using UnityEngine;

public class Deck {
    public Card[,] cards;
    public int NUM_SUITS = System.Enum.GetValues(typeof(Suit)).Length;
    public int NUM_VALUES = System.Enum.GetValues(typeof(Value)).Length;

    public Deck (){
        cards = new Card[NUM_SUITS, NUM_VALUES];
        Suit[] suits = (Suit[]) System.Enum.GetValues(typeof(Suit));
        Value[] values = (Value[]) System.Enum.GetValues(typeof(Value));
        
        for (int suitIndex = 0; suitIndex < NUM_SUITS; suitIndex++) {
            Suit suit = suits[suitIndex];
            for (int valueIndex = 0; valueIndex < NUM_VALUES; valueIndex++) {
                Value value = values[valueIndex];
                cards[suitIndex, valueIndex] = new Card(suit, value);
            }
        }
    }
}