using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    int lanes = 4;
    public CardSlot[,] cardSlots;
    void OnValidate()
    {
        GenerateBoard();
    }
    void Start()
    {
        GenerateBoard();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GenerateBoard()
    {
        //0 = player row, 1 = enemy row, 2 = enemy preview row
        cardSlots = new CardSlot[lanes, 3];

        //player row
        for(int i = 0; i < lanes; i++)
        {
            cardSlots[i, 0] = new CardSlot(0, this);
        }
        //enemy row
        for (int i = 2; i < lanes; i++)
        {
            cardSlots[i, 0] = new CardSlot(1, this);
        }
        //enemy preview row
        for (int i = 0; i < lanes; i++)
        {
            cardSlots[i, 0] = new CardSlot(2, this);
        }


    }
}
