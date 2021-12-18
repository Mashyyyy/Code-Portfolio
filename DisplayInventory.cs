using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DisplayInventory : MonoBehaviour
{
    public InventoryContainer inventory;
    Dictionary<InventorySlot, GameObject> itemsDisplayed = new Dictionary<InventorySlot, GameObject>();
    private void Start()
    {
        for(int i = 0; i < inventory.Container.Count; i++)
        {
            var obj = Instantiate(inventory.Container[i].item.itemPrefab, this.gameObject.transform);
            itemsDisplayed.Add(inventory.Container[i], obj);
        }
    }

    private void Update()
    {
        UpdateDisplay();
    }

    void UpdateDisplay()
    {
        for(int i = 0; i < inventory.Container.Count; i++)
        {
            if (itemsDisplayed.ContainsKey(inventory.Container[i]))
            {
                //Already in inventory
            }
            else
            {
                var obj = Instantiate(inventory.Container[i].item.itemPrefab, this.gameObject.transform);
                itemsDisplayed.Add(inventory.Container[i], obj);
            }
        }
    }

    public void RemoveFromInventory(int index)
    {
        var obj = itemsDisplayed.Single(s => s.Key == inventory.Container[index]).Value;
        Destroy(obj);
        itemsDisplayed.Remove(inventory.Container[index]);
        inventory.Container.Remove(inventory.Container[index]);
    }
}