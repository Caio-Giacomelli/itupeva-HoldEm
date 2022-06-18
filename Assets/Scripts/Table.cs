using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Table {
    public Card[] _cards {get; private set;}
    public int _currentTurn;

    public Table(Card[] tableCards) {
        this._cards = tableCards;
        this._currentTurn = 0;
    }
}
