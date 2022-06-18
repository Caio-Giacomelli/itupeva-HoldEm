using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
    [Header("Game Configuration")]
    [SerializeField] public int _playerCount;
    [SerializeField] public TurnController _turnController;

    [Header("Card Configuration")]
    [SerializeField] public Sprite[] _cardSprites;
    
    public Deck _deck;
    private int _turnCount; 

    void Start() {
        _turnCount = 0;
        this._deck = new Deck(_cardSprites);
    }

    public void initializeTurn(){
        _turnController.runTurn(_turnCount, _playerCount, this._deck);
    }
}
