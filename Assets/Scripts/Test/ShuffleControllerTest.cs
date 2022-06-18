using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShuffleControllerTest : MonoBehaviour
{
    private static int TEST_RECURRENCE = 100000;
    private static int SUIT_POSITION_REFERENCE = 3;
    private static int VALUE_POSITION_REFERENCE = 9;
    private ShuffleController _shuffleController = new ShuffleController();
    
    public void executeShuffleTest(){
        
        int[] lValues = new int[TEST_RECURRENCE];
        int[] lSuits = new int[TEST_RECURRENCE];
        int[] lCountValues = new int[13];
        int[] lCountSuits = new int[4];

        for (int i = 0; i < TEST_RECURRENCE; i++){ 
            Deck deck = new Deck(new Sprite[52]);
            Deck shuffledDeck = _shuffleController.shuffleCards(deck);
            lValues[i] = (int) shuffledDeck._cards[SUIT_POSITION_REFERENCE, VALUE_POSITION_REFERENCE]._value;
            lSuits[i] = (int) shuffledDeck._cards[SUIT_POSITION_REFERENCE, VALUE_POSITION_REFERENCE]._suit;
        }

        Value[] values = (Value[]) System.Enum.GetValues(typeof(Value));
        Suit[] suits = (Suit[]) System.Enum.GetValues(typeof(Suit));

        for (int i = 0; i < values.Length; i++){
            for (int j = 0; j < TEST_RECURRENCE; j++){
                if ((int)values[i] == lValues[j]){
                    lCountValues[i] += 1;
                }
            }
        }

        for (int i = 0; i < suits.Length; i++){
            for (int j = 0; j < TEST_RECURRENCE; j++){
                if ((int)suits[i] == lSuits[j]){
                    lCountSuits[i] += 1;
                }
            }
        }

        for (int i = 0; i < lCountSuits.Length; i++){
            Debug.Log("Suits Occurrence: " + i + " : " + lCountSuits[i]);
        }

        for (int i = 0; i < lCountValues.Length; i++){
            Debug.Log("Values Occurrence: " + i + " : " + lCountValues[i]);
        }

    }
}
