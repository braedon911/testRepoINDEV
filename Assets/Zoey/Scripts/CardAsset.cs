using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(), System.Serializable()]
public class CardAsset : ScriptableObject
{
    public string header;
    public Sprite art;
    public int power = 0;
    public int health = 1;
    public int cost = 0;
}
