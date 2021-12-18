using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Puzzle Item", menuName = "Inventory/Items/Puzzle Item")]
public class PuzzleItem : ItemObject
{
    private void Awake()
    {
        Itype = ItemType.puzzleItem;
    }
}