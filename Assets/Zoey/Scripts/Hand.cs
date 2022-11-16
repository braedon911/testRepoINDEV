using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    [SerializeField]
    List<CardObject> cards;
    [SerializeField]
    Transform anchor;
    public float horizontalSeparation = 2;
    void Start()
    {
        
    }

    void OnValidate()
    {
        RenderCards();
    }

    void RenderCards()
    {
        int handSize = cards.Count;
        float handWidth = (handSize - 1) * horizontalSeparation;
        float farLeft = anchor.position.x - handWidth/2;

        for(int i = 0; i < handSize; i++)
        {
            CardObject card = cards[i];
            card.transform.position = Vector3.right * (farLeft + (i * horizontalSeparation)) + (Vector3.up * Mathf.Sin(i/(2*Mathf.PI) - Mathf.PI));
        }
    }

    void Update()
    {
        
    }
}
