using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Refactor to round controller
public class TurnController : MonoBehaviour{
    [Header("Game Configuratation")]
    [SerializeField] public int _playerNumber = 1;

    private ShuffleController _shuffleController;
    public Hand[] _playerHands;
    public Table _table;
    public Deck _deck;

    void Start(){
       this._shuffleController  = new ShuffleController();
       this._deck = new Deck();
       this._playerHands = new Hand[_playerNumber];

       this.shuffleDeck();
       this.dealCards();
       this.dealTable();
       this.printHands();
       this.printTable();
    }

    public void shuffleDeck(){
        this._deck = _shuffleController.shuffleCards(this._deck);
    }

    public void dealCards(){
        for (int i = 0; i < _playerNumber; i++){
            Card[] cardsToDeal = this._deck.dealCards(2);
            _playerHands[i] = new Hand(cardsToDeal, i);
        }
    }

    public void printHands(){
        for (int i = 0; i < _playerNumber; i++){
            Debug.Log("Hand " + i + ": " + _playerHands[i]._cards[0].getCardString());
            Debug.Log("Hand " + i + ": " + _playerHands[i]._cards[1].getCardString());
        }
    }

    public void dealTable(){
        Card[] cardsToDeal = this._deck.dealCards(5);
        _table = new Table(cardsToDeal);
    }

    public void printTable(){
        for (int i = 0; i < 5; i++){
            Debug.Log("Table: " + _table._cards[i].getCardString());
        }
    }
}
