using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardObject : MonoBehaviour
{
    public CardAsset cardAsset;
    public SpriteRenderer spriteRenderer;

    void OnValidate()
    {
        UpdateCard();
    }
    void Start()
    {
        UpdateCard();
    }
    void UpdateCard()
    {
        spriteRenderer.sprite = cardAsset.art;
    }
}
