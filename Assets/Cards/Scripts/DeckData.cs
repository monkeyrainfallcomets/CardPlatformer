using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckData : MonoBehaviour
{
    List<Card> deck = new List<Card>();
    public List<Card> Deck { get { return deck; } }
    List<Card> hand = new List<Card>();
    public List<Card> Hand { get { return hand; } }
    public DeckData(List<Card> deck, List<Card> hand)
    {
        this.deck = deck;
        this.hand = hand;
    }
}
