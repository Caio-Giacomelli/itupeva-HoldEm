using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShuffleController {    
    
    public Deck shuffleCards(Deck deckToShuffle){
        System.Random rng = new System.Random();
        Card[,] cardsToShuffle = deckToShuffle._cards;

        int lengthRow = cardsToShuffle.GetLength(1);
        for (int i = cardsToShuffle.Length - 1; i > 0; i--){
            int i0 = i / lengthRow;
            int i1 = i % lengthRow;

            int j = rng.Next(i + 1);
            int j0 = j / lengthRow;
            int j1 = j % lengthRow;

            Card temp = cardsToShuffle[i0, i1];
            cardsToShuffle[i0, i1] = cardsToShuffle[j0, j1];
            cardsToShuffle[j0, j1] = temp;
        }

        return new Deck(cardsToShuffle);
    }

    /*public void shuffleCardButtonAction(){
        Card[,] generatedDeck = shuffleCards();
    }*/
}