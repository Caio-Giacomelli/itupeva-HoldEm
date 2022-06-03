using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShuffleController : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void shuffleCards(){
        Card card = new Card(Suit.SPADES, Value.ACE);
        Debug.Log(card.value);
    }
}
