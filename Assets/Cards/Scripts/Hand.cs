using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand
{
    List<RunnableCard> cards;

    public Hand(int capacity)
    {
        cards = new List<RunnableCard>(capacity);
    }

    public Hand(List<RunnableCard> cards, int capacity)
    {
        this.cards = cards;
        cards.Capacity = capacity;
    }

    public void PlayCard(int index)
    {
        cards[index].Use();
        cards.RemoveAt(index);
    }

    public Card GetCard(int index)
    {
        return cards[index].GetCard();
    }

    public int CardCount()
    {
        return cards.Count;
    }
}
