using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1_LoadToNext : MonoBehaviour
{
    private GameManager gameManager;

    [SerializeField]
    private Texture2D cursorInspect;
    [SerializeField]
    private Texture2D cursorDefault;

    [SerializeField]
    private Transform point;
    [SerializeField]
    private float radius;
    [SerializeField]
    private LayerMask layerMask;

    private bool isActive;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    private void Update()
    {
        isActive = Physics2D.OverlapCircle(point.position, radius, layerMask);
    }

    public void OnHover_Mouse()
    {
        Cursor.SetCursor(cursorInspect, Vector2.zero, CursorMode.Auto);
    }

    public void UnHover_Mouse()
    {
        Cursor.SetCursor(cursorDefault, Vector2.zero, CursorMode.Auto);
    }

    public void OnClick_LevelLoad()
    {
        if(isActive)
            gameManager.LoadToNextLevel();
    }
}