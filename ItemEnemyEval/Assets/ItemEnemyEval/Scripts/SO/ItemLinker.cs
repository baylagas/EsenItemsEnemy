using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="sc_ItemLinker", menuName ="ItemLinker")]
public class ItemLinker : ScriptableObject
{
    public string linkerName;
    public Sprite image;
    public Sprite changeToSprite;
    public List<ItemLinked> linkedArray;
}
