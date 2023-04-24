using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck
{
    List<Card> cards;
    public Deck(int capacity)
    {
        cards = new List<Card>(capacity);
    }

    public Deck(List<Card> cards, int capacity)
    {
        this.cards = cards;
        cards.Capacity = capacity;
    }

    public Card GetTopCard()
    {
        return cards[cards.Count - 1];
    }

    public bool GetTopCards(int count, out Card[] revealedCards)
    {
        if (count > cards.Count)
        {
            revealedCards = new Card[count];
            for (int i = 0; i <= count - 1; i++)
            {
                revealedCards[i] = cards[cards.Count - i - 1];
            }
            return true;
        }
        revealedCards = null;
        return false;
    }

    //moves the top card to the bottom of the stack
    public void TopCardToBottom()
    {
        cards.Insert(0, cards[cards.Count - 1]);
        cards.RemoveAt(cards.Count - 1);
    }

    public Card DrawTopCard()
    {
        Card card = GetTopCard();
        cards.RemoveAt(cards.Count - 1);
        return card;
    }

    public void Shuffle()
    {
        List<Card> placeHolder = new List<Card>();
        for (int i = 0; i < cards.Count; i++)
        {
            int index = Random.Range(0, cards.Count);
            Card card = cards[index];
            cards.RemoveAt(index);
            placeHolder.Add(card);
        }
        cards = placeHolder;
    }

}
