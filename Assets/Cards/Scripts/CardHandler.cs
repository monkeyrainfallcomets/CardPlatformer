using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardHandler : MonoBehaviour
{
    Hand hand;
    DrawHandler drawHandler;


    public void SetDeck(DrawHandler drawHandler, Hand hand)
    {
        this.drawHandler = drawHandler;
        this.hand = hand;
    }
}
