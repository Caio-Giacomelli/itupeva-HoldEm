using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnController : MonoBehaviour{
    public Hand[] _playerHands;
    public Table _table;

    private ShuffleController _shuffleController;
    private Deck _deck;

    void Start(){
       this._shuffleController  = new ShuffleController();
    }

    public void runTurn(int turnCount, int remainingPlayers, Deck deck){
       this.initializeHand(remainingPlayers);
       this.prepareDeck(deck);
       this.dealCards(remainingPlayers);
       this.dealTable();
       this.printHands(remainingPlayers);
       this.printTable();
    }

    private void initializeHand(int remainingPlayers){
        this._playerHands = new Hand[remainingPlayers];
    }

    private void prepareDeck(Deck deck){
        deck.resetDeck();
        this._deck = _shuffleController.shuffleCards(deck);
    }

    private void dealCards(int remainingPlayers){
        for (int i = 0; i < remainingPlayers; i++){
            Card[] cardsToDeal = this._deck.dealCards(2);
            _playerHands[i] = new Hand(cardsToDeal, i);
        }
    }

    private void printHands(int remainingPlayers){
        for (int i = 0; i < remainingPlayers; i++){
            Debug.Log("Hand " + i + ": " + _playerHands[i]._cards[0].getCardString());
            Debug.Log("Hand " + i + ": " + _playerHands[i]._cards[1].getCardString());
        }
    }

    private void dealTable(){
        Card[] cardsToDeal = this._deck.dealCards(5);
        _table = new Table(cardsToDeal);
    }

    private void printTable(){
        for (int i = 0; i < 5; i++){
            Debug.Log("Table: " + _table._cards[i].getCardString());
        }
    }
}
