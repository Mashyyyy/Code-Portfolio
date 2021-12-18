using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AutoSave : MonoBehaviour
{
    [SerializeField]
    private InventoryContainer inventory;
    string jsonsaveFile;
    public GameObject saveIcon;

    [HideInInspector]
    public int currentLevelToLoad;

    private void Start()
    {
        currentLevelToLoad = PlayerPrefs.GetInt("currentLevelLoad");
        Debug.Log(currentLevelToLoad);
    }

    private class playerDataActual
    {
        public int currentLevel;
    }

    public void SaveData()
    {
        #region JSON_PrototypeSaveFile
        /*
        saveIcon.SetActive(true);
        playerDataActual newplayerdataActual = new playerDataActual();
        newplayerdataActual.currentLevel = SceneManager.GetActiveScene().buildIndex;

        jsonsaveFile = JsonUtility.ToJson(newplayerdataActual);
        Debug.Log("Saved Data...");
        //File.WriteAllText(Application.dataPath + "/saveFile.json", jsonsaveFile);
        */
        #endregion
        PlayerPrefs.SetInt("currentLevelLoad", SceneManager.GetActiveScene().buildIndex);
        PlayerPrefs.Save();
        saveIcon.SetActive(true);
        Debug.Log("Saved Data...");
    }

    public void LastSave()
    {
        /*
        playerDataActual playerdataActual = new playerDataActual();
        playerdataActual.currentLevel = 1;
        inventory.Container.Clear();
        jsonsaveFile = JsonUtility.ToJson(playerdataActual);
        */

        PlayerPrefs.DeleteAll();
        PlayerPrefs.Save();
        inventory.Container.Clear();
        //File.WriteAllText(Application.dataPath + "/saveFile.json", jsonsaveFile);
    }

    public void LoadData()
    {
        playerDataActual loadedPlayerData = JsonUtility.FromJson<playerDataActual>(jsonsaveFile);
        //inventory = loadedPlayerData.inventory;
    }

    private void OnApplicationQuit()
    {
        SaveData();
    }
}