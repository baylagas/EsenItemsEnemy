using UnityEngine;

[CreateAssetMenu(fileName = "sc_LinkProperty", menuName = "LinkProperty")]
public class LinkProperty : ScriptableObject
{
    public ItemLinker linker;
    public ItemLinked linkedItem;
    public bool isObtained;
}
