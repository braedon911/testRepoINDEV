using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSlot
{
    GameObject card;
    CardObject cardComponent;
    Boolean occupied = false;
    //state 0 = player, state 1 = enemy, state 2 = enemy preview?
    int state = 0;
    Board board;
    public void PlaceCard(CardObject newCard)
    {
        if (!occupied)
        {
            cardComponent = newCard;
            card = newCard.gameObject;
            occupied = true;
        }
    }
    public bool IsOccupied()
    {
        return occupied;
    }
    public GameObject Clear()
    {
        occupied = false;
        card = null;
        cardComponent = null;
        return card;
    }

    public CardSlot(int state, Board board)
    {
        this.state = state;
        this.board = board;
    }


}
