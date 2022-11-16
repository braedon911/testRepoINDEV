using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    List<CardAsset> cards = new List<CardAsset>();

    public void Shuffle()
    {
        int n = cards.Count;
        System.Random random = new System.Random();
        while(n > 1)
        {
            n--;
            int k = random.Next(n + 1);
            CardAsset swap = cards[k];
            cards[k] = cards[n];
            cards[n] = swap;
        }
    }
    public CardAsset Pop(int index=0)
    {
        CardAsset card = cards[index];
        cards.RemoveAt(index);
        return card;
    }
}
