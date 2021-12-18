using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBehaviourProper : MonoBehaviour
{
    private ObjectMenuInteraction objectMenu;
    [SerializeField]
    private ItemObject Item;

    void Start()
    {
        objectMenu = FindObjectOfType<ObjectMenuInteraction>();
    }

    public void OnClick_Activate()
    {
        objectMenu.OnClick_Interact();
        string[] newData = { Item.description };
        objectMenu.updateItemDescription(newData);
    }
}