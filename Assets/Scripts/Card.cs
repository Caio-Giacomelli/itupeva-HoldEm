public enum Suit {
    HEARTS, SPADES, DIAMONDS, CLUBS
}

public enum Value {
    ACE, TWO, THREE, FOUR, FIVE, SIX, SEVEN,
    EIGHT, NINE, TEN, JACK, QUEEN, KING
}

public class Card {
    public Suit suit;
    public Value value;
    public bool withdrew;

    public Card (Suit suit, Value value){
        this.suit = suit;
        this.value = value;
        this.withdrew = false;
    }

    public string getCardString(){
        return this.value  + " of " + this.suit;
    }
}
