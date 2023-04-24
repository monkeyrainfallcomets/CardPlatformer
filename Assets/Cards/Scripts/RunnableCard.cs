using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunnableCard
{
    CardActionHandler handler;
    Card card;
    public RunnableCard(CardActionHandler handler, Card card)
    {
        this.handler = handler;
        this.card = card;
    }

    public void Use()
    {
        for (int i = 0; i < card.Actions.Count; i++)
        {
            card.Actions[i].RunAction(handler);
        }
    }
}
