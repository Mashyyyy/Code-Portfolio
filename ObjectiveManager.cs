using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObjectiveManager : MonoBehaviour
{
    private GameManager gameManager;
    public List<TextMeshProUGUI> objectives;
    int currentLevel;
    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        currentLevel = gameManager.currentLevel;
    }

    private void Update()
    {
        switch (currentLevel)
        {
            case 1:
                {
                    #region LEVEL1_Objectives
                    if (!gameManager.canLoadToNextLevel && gameManager.playerInventory.Container.Count != 3)
                    {
                        objectives[0].gameObject.SetActive(true);
                        objectives[0].text = "Collect all clutter in your room.";
                    }
                    else if (!gameManager.canLoadToNextLevel && gameManager.playerInventory.Container.Count == 3)
                    {
                        objectives[0].fontStyle = FontStyles.Strikethrough;
                        objectives[1].gameObject.SetActive(true);
                        objectives[1].text = "Inspect the Strange Creature";
                    }
                    else if(gameManager.canLoadToNextLevel && gameManager.playerInventory.Container.Count == 3)
                    {
                        objectives[1].fontStyle = FontStyles.Strikethrough;
                        objectives[2].gameObject.SetActive(true);
                        objectives[2].text = "Go to Bed";
                    }
                    break;
                    #endregion
                }
            case 2:
                {
                    #region LEVEL2_Objectives
                    objectives[0].gameObject.SetActive(true);
                    objectives[0].text = "Exit your room through the door";
                    break;
                    #endregion
                }
            case 3:
                {
                    #region LEVEL3_Objectives
                    if (!gameManager.gotBread)
                    {
                        objectives[0].gameObject.SetActive(true);
                        objectives[0].text = "Get the bread";
                    }
                    else if(gameManager.gotBread && !gameManager.canLoadToNextLevel)
                    {
                        objectives[0].fontStyle = FontStyles.Strikethrough;
                        objectives[1].gameObject.SetActive(true);
                        objectives[1].text = "Talk to the mysterious entity";
                    }
                    else if(gameManager.gotBread && gameManager.canLoadToNextLevel)
                    {
                        objectives[1].fontStyle = FontStyles.Strikethrough;
                        objectives[2].gameObject.SetActive(true);
                        objectives[2].text = "Exit the kitchen through the door";
                    }
                    break;
                    #endregion
                }
            case 4:
                {
                    #region LEVEL4_Objectives
                    objectives[0].gameObject.SetActive(true);
                    objectives[0].text = "Exit the living room";
                    break;
                    #endregion
                }
            case 5:
                {
                    #region LEVEL5_Objectives
                    if (!gameManager.canLoadToNextLevel)
                    {
                        objectives[0].gameObject.SetActive(true);
                        objectives[0].text = "Talk to Shadow";
                    }
                    else
                    {
                        objectives[0].fontStyle = FontStyles.Strikethrough;
                        objectives[1].gameObject.SetActive(true);
                        objectives[1].text = "Proceed left to go to school";
                    }
                    break;
                    #endregion
                }
            case 6:
                {
                    #region LEVEL6_Objectives
                    if (!gameManager.canLoadToNextLevel)
                    {
                        objectives[0].gameObject.SetActive(true);
                        objectives[0].text = "Talk to Shadow";
                    }
                    else
                    {
                        objectives[0].fontStyle = FontStyles.Strikethrough;
                        objectives[1].gameObject.SetActive(true);
                        objectives[1].text = "Proceed left to enter school";
                    }
                    break;
                    #endregion
                }
            case 7:
                {
                    #region LEVEL7_Objectives
                    if (!gameManager.canLoadToNextLevel)
                    {
                        objectives[0].gameObject.SetActive(true);
                        objectives[0].text = "Talk to Shadow";
                    }
                    else
                    {
                        objectives[0].fontStyle = FontStyles.Strikethrough;
                        objectives[1].gameObject.SetActive(true);
                        objectives[1].text = "Continue Walking left";
                    }
                    break;
                    #endregion
                }
            case 8:
                {
                    #region LEVEL8_Objectives
                    objectives[0].gameObject.SetActive(true);
                    objectives[0].text = "Keep walking to the left";
                    break;
                    #endregion
                }
            case 9:
                {
                    #region LEVEL9_Objectives
                    if (!gameManager.canLoadToNextLevel)
                    {
                        objectives[0].gameObject.SetActive(true);
                        objectives[0].text = "Talk to Shadow";
                    }
                    else
                    {
                        objectives[0].fontStyle = FontStyles.Strikethrough;
                        objectives[1].gameObject.SetActive(true);
                        objectives[1].text = "Exit the room through the door";
                    }
                    break;
                    #endregion
                }
            case 10:
                {
                    #region LEVEL10_Objectives
                    if (!gameManager.canLoadToNextLevel)
                    {
                        objectives[0].gameObject.SetActive(true);
                        objectives[0].text = "Talk to Shadow";
                    }
                    else
                    {
                        objectives[0].fontStyle = FontStyles.Strikethrough;
                        objectives[1].gameObject.SetActive(true);
                        objectives[1].text = "Proceed walking to right to exit school.";
                    }
                    break;
                    #endregion
                }
            case 11:
                {
                    #region LEVEL11_Objectives
                    if (!gameManager.canLoadToNextLevel)
                    {
                        objectives[0].gameObject.SetActive(true);
                        objectives[0].text = "Talk to Shadow";
                    }
                    else if(gameManager.canLoadToNextLevel && !gameManager.givenBread)
                    {
                        objectives[0].fontStyle = FontStyles.Strikethrough;
                        objectives[1].gameObject.SetActive(true);
                        objectives[1].text = "Talk to the cat again and give your bread.";
                    }
                    else if(gameManager.canLoadToNextLevel && gameManager.givenBread)
                    {
                        objectives[1].fontStyle = FontStyles.Strikethrough;
                        objectives[2].gameObject.SetActive(true);
                        objectives[2].text = "Proceed walking to right to go home";
                    }
                    break;
                    #endregion
                }
            case 12:
                {
                    #region LEVEL12_Objectives
                    objectives[0].gameObject.SetActive(true);
                    objectives[0].text = "Inspect the glowing object";
                    break;
                    #endregion
                }
            case 13:
                {
                    #region LEVEL13_Objectives
                    break;
                    #endregion
                }
            // levels 21, 22, and 23 are special levels
            case 14:
            case 21:
            case 22:
                {
                    #region LEVEL14_Objectives
                    if (!gameManager.canLoadToNextLevel)
                    {
                        objectives[0].gameObject.SetActive(true);
                        objectives[0].text = "Talk to Shadow";
                    }
                    else if(PlayerPrefs.GetInt("CluesFound") < 2)
                    {
                        objectives[0].fontStyle = FontStyles.Strikethrough;
                        objectives[1].gameObject.SetActive(true);
                        if(PlayerPrefs.GetInt("CluesFound") != 2)
                            objectives[1].text = "Find the clues [" + PlayerPrefs.GetInt("CluesFound") + "/2]";
                    }
                    else if(PlayerPrefs.GetInt("CluesFound") == 2)
                    {
                        objectives[0].gameObject.SetActive(true);
                        objectives[1].gameObject.SetActive(false);
                        objectives[2].gameObject.SetActive(false);
                        objectives[0].text = "Return to your Room";
                    }
                    break;
                    #endregion
                }
            case 23:
                {
                    objectives[0].gameObject.SetActive(true);
                    objectives[0].text = "Return to your Room";
                    break;
                }
            case 24:
                {
                    objectives[0].gameObject.SetActive(true);
                    objectives[0].text = "Grab the photo";
                    break;
                }
            case 15:
                {
                    #region LEVEL15_Objectives
                    objectives[0].gameObject.SetActive(true);
                    objectives[0].text = "Go back to your room to your right";
                    break;
                    #endregion
                }
            case 16:
                {
                    #region LEVEL16_Objectives
                    break;
                    #endregion
                }
        }
    }
}