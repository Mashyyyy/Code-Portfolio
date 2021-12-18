using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Quest Object", menuName = "Inventory/Items/Quest Item")]
public class QuestItem : ItemObject
{
    private void Awake()
    {
        Itype = ItemType.questItem;
    }
}