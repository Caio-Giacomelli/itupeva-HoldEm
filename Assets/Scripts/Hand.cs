using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand {
    public Card[] _cards;
    public int _playerId;

    public Hand(Card[] handCards, int playerId) {
        this._cards = handCards; 
        this._playerId = playerId;
    }
}
