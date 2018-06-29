using UnityEngine;

[CreateAssetMenu(fileName = "sc_ItemLinked", menuName = "ItemLinked")]
public class ItemLinked : ScriptableObject
{
    public string linkedName;
    public Sprite image;
    public LinkProperty property;
}
