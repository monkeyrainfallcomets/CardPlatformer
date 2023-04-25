using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawHandler
{
    DrawPile drawPile;
    Deck discardPile;
    bool refillDrawPile;

    DrawHandler(DrawPile drawPile, bool refillDrawPile, int capacity)
    {
        this.drawPile = drawPile;
        this.discardPile = new Deck(capacity);
    }

    public RunnableCard DrawTopCard()
    {
        //impliment drawPileEmpty check
        return drawPile.DrawTopCard();
    }

    public void ShuffleDrawDeck()
    {
        drawPile.Shuffle();
    }

    public Card GetTopCard()
    {
        return drawPile.GetTopCard();
    }

    public bool GetTopCards(int count, out Card[] revealedCards)
    {
        return drawPile.GetTopCards(count, out revealedCards);
    }

    public Card ReviveTopDiscardedCard()
    {
        return discardPile.DrawTopCard();
    }

    public Card GetTopDiscardedCard()
    {
        return discardPile.GetTopCard();
    }

    public bool GetTopDiscardedCards(int count, out Card[] revealedCards)
    {
        return discardPile.GetTopCards(count, out revealedCards);
    }
}
