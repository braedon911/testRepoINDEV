using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class CardObject : MonoBehaviour
{
    public CardAsset cardAsset;
    public SpriteRenderer spriteRenderer;
    public TMP_Text nameText, powerText, healthText;

    

    void OnValidate()
    {
        cardAsset.cardValidater.AddListener(UpdateCard);
        UpdateCard();
    }
    void Start()
    {
        UpdateCard();
    }
    void UpdateCard()
    {
        spriteRenderer.sprite = cardAsset.art;
        nameText.text = cardAsset.cardName;
        powerText.text = cardAsset.power.ToString();
        healthText.text = cardAsset.health.ToString();
    }
}
