using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public enum ItemType
{
    questItem,
    puzzleItem,
    defaultItem
}

public abstract class ItemObject : ScriptableObject
{
    public GameObject itemPrefab;
    public ItemType Itype;

    public string itemName;
    [TextArea(15, 20)]
    public string description;
}