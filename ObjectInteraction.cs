using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInteraction : MonoBehaviour
{
    public InventoryContainer playerInven;

    private Transform point;
    [SerializeField]
    private float radius;
    [SerializeField]
    private LayerMask layerMask;

    private bool isActive;

    [SerializeField]
    private Texture2D inspectCursor;
    [SerializeField]
    private Texture2D grabCursor;
    [SerializeField]
    private Texture2D defaultCursor;

    public GameObject poiIcon;

    private void Start()
    {
        point = GetComponent<Transform>();
    }

    private void Update()
    {
        isActive = Physics2D.OverlapCircle(point.position, radius, layerMask);

        if (isActive)
        {
            poiIcon.SetActive(true);
        }
        else
        {
            poiIcon.SetActive(false);
        }
    }


    //Clicked / Obtained the Object
    public void OnClick_GetObject()
    {
        if (isActive)
        {
            var item = GetComponent<Item>();
            playerInven.AddItem(item.itemInfo, 1);
            Cursor.SetCursor(defaultCursor, Vector2.zero, CursorMode.Auto);
            var gameManager = FindObjectOfType<GameManager>();
            switch (gameManager.currentLevel)
            {
                case 3:
                    {
                        gameManager.gotBread = true;
                        break;
                    }
            }
            Destroy(this.gameObject);
        }
        else
        {
            Debug.Log("Player cannot reach that object.");
        }
    }


    //Entered in the trigger zone
    public void OnHover_Object()
    {
        if (isActive)
        {
            Cursor.SetCursor(grabCursor, Vector2.zero, CursorMode.Auto);
        }
        else
        {
            Cursor.SetCursor(inspectCursor, Vector2.zero, CursorMode.Auto);
        }
        Debug.Log("On Object");
    }

    //Exited in the trigger zone
    public void OnUnHover_Object()
    {
        Cursor.SetCursor(defaultCursor, Vector2.zero, CursorMode.Auto);
        Debug.Log("Off Object");
    }
}