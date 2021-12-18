using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    [SerializeField]
    private Texture2D cursorDefault;
    [SerializeField]
    private Texture2D cursorInspect;

    private GameManager gameManager;

    private Transform point;
    [SerializeField]
    private float radius;
    [SerializeField]
    private LayerMask layerMask;

    private bool isActive;


    private void Update()
    {
        isActive = Physics2D.OverlapCircle(point.transform.position, radius, layerMask);
    }

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        point = GetComponent<Transform>();
    }

    public void OnHover_Mouse()
    {
        Cursor.SetCursor(cursorInspect, Vector2.zero, CursorMode.Auto);
    }

    public void UnHover_Mouse()
    {
        Cursor.SetCursor(cursorDefault, Vector2.zero, CursorMode.Auto);
    }

    public void OnClick_Door()
    {
        if (isActive)
            gameManager.LoadToNextLevel();
        else
            Debug.Log("Too far away.");
    }
}