using System.Collections.Generic;
using UnityEngine;

public enum Suit {
    HEARTS, SPADES, DIAMONDS, CLUBS
}

public enum Value {
    ACE, TWO, THREE, FOUR, FIVE, SIX, SEVEN,
    EIGHT, NINE, TEN, JACK, QUEEN, KING
}

public class Card {
    public Suit _suit;
    public Value _value;
    public Sprite _cardSprite;
    public bool _withdrew;

    public Card (Suit suit, Value value, Sprite cardSprite){
        this._suit = suit;
        this._value = value;
        this._cardSprite = cardSprite;
        this._withdrew = false;
    }

    public string getCardString(){
        return this._value  + " of " + this._suit;
    }
}
