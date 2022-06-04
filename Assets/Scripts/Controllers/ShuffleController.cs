using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShuffleController : MonoBehaviour {    
    
    public Card[,] shuffleCards(){
        Deck deck = new Deck();
        System.Random rng = new System.Random();
        Card[,] generatedDeck = deck.cards;

        int lengthRow = generatedDeck.GetLength(1);
        for (int i = generatedDeck.Length - 1; i > 0; i--){
            int i0 = i / lengthRow;
            int i1 = i % lengthRow;

            int j = rng.Next(i + 1);
            int j0 = j / lengthRow;
            int j1 = j % lengthRow;

            Card temp = generatedDeck[i0, i1];
            generatedDeck[i0, i1] = generatedDeck[j0, j1];
            generatedDeck[j0, j1] = temp;
        }

        return generatedDeck;
    }

    public void shuffleCardButtonAction(){
        Card[,] generatedDeck = shuffleCards();
    }

    private void printDeck(Card[,] generatedDeck, string message){
        int NUM_SUITS = System.Enum.GetValues(typeof(Suit)).Length;
        int NUM_VALUES = System.Enum.GetValues(typeof(Value)).Length;
        
        for (int suitIndex = 0; suitIndex < NUM_SUITS; suitIndex++) {
            for (int valueIndex = 0; valueIndex < NUM_VALUES; valueIndex++) {
                Debug.Log(message + " " + generatedDeck[suitIndex, valueIndex].value);
                Debug.Log(message + " " + generatedDeck[suitIndex, valueIndex].suit);
            }
        }
    }
}