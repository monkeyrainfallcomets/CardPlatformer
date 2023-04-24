using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawPile
{
    Deck drawDeck;
    CardActionHandler actionHandler;
    public DrawPile(Deck drawDeck, CardActionHandler actionHandler)
    {
        this.drawDeck = drawDeck;
        this.actionHandler = actionHandler;
    }

    public DrawPile(CardActionHandler cardActionHandler, int capacity)
    {
        this.actionHandler = cardActionHandler;
        drawDeck = new Deck(capacity);
    }

    public RunnableCard DrawTopCard()
    {
        return new RunnableCard(actionHandler, drawDeck.DrawTopCard());
    }

    public Card GetTopCard()
    {
        return drawDeck.GetTopCard();
    }
    public bool GetTopCards(int count, out Card[] revealedCards)
    {
        return drawDeck.GetTopCards(count, out revealedCards);
    }

    public void Shuffle()
    {
        drawDeck.Shuffle();
    }

    public void TopCardToBottom()
    {
        drawDeck.TopCardToBottom();
    }
}
