using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public InventoryContainer inventory;

    private void OnApplicationQuit()
    {
        //inventory.Container.Clear();
    }
}