using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public static GameManager instance = null;
    //public static Dialog dialog = new Dialog();
    [SerializeField] public static int currentDialogId = 0;
    [SerializeField] public static Dictionary<int, Dialog> dialog = new Dictionary<int, Dialog>();
    public static Dictionary<String, bool> items = new Dictionary<string, bool>();
    public static int countInitialItems = 0;
    public int current;
    public GameObject panelInitialItems;
    public static int currentInteraction = 0;
    public static int[] countInteraction = { 0, 0, 0 };
    public string json;
    public static bool loadConcluded = false;

    public Text texto;
    public Text charName;

    public Material materialChar;
    public Material materialBack;

    void Start()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        loadConcluded = false;
        dialog.Clear();
        StartCoroutine("LoadDialogs");

        currentDialogId = 0;

        InitializeItems();

        panelInitialItems.SetActive(false);
    }

    void InitializeItems()
    {
        items.Clear();
        items.Add("PLUSHIE", false);
        items.Add("VIDEOGAME", false);
        items.Add("PAINTING", false);
        items.Add("LAPTOP", false);
        items.Add("BOOK", false);
        items.Add("BED", false);
        items.Add("BUREAU", false);
        items.Add("SOFA", false);
        items.Add("STATUATE", false);
        items.Add("HATSTAND", false);
        items.Add("CATDOG", false);
        items.Add("POSTER", false);
        items.Add("WALKIETALKIE", false);
        items.Add("ARCADE", false);
        items.Add("PLANT", false);
        items.Add("ONESIE", false);
        items.Add("PILLOW", false);
        items.Add("WHEELCHAIR", false);
        countInitialItems = 0;
        currentInteraction = 0;
        countInteraction[0] = 0;
        countInteraction[1] = 0;
        countInteraction[2] = 0;
    }

    IEnumerator LoadDialogs()
    {
        string path = Application.dataPath + "/StreamingAssets/" + Localization.fileName;
        //string path = "http://localhost:8000/StreamingAssets/" + Localization.fileName;

        if (path.Contains("://") || path.Contains(":///"))
        {
            WWW www = new WWW(path);
            yield return www;

            if (string.IsNullOrEmpty(www.error))
                json = System.Text.Encoding.UTF8.GetString(www.bytes, 3, www.bytes.Length - 3);  // Skip thr first 3 bytes (i.e. the UTF8 BOM)
 
        }
        else
            json = File.ReadAllText(path);

        GameDialogs g = JsonUtility.FromJson<GameDialogs>(json);
        foreach (Dialog d in g.gameDialog)
        {
            if (!dialog.ContainsKey(d.id))
                dialog.Add(d.id, d);

            if(!loadConcluded)
                loadConcluded = true;
            yield return null;
        }
        
    }

    public void SelectItem(string item)
    {
        countInitialItems++;
        if (countInitialItems == 3 && panelInitialItems.activeSelf == true)
        {
            panelInitialItems.SetActive(false);
        }
        items[item] = true;
    }

    void Update()
    {
        if (loadConcluded)
        { 
            if (dialog[currentDialogId].id == 4 && countInitialItems < 3)
            {
                if (!panelInitialItems.activeSelf)
                {
                    panelInitialItems.SetActive(true);
                }

                //panelInitialItems = GameObject.FindGameObjectWithTag("threeoffive");
            }

            if (current != currentDialogId)
            {
                current = currentDialogId;
                StartCoroutine(LoadStreamingAssetChar());
                StartCoroutine(LoadStreamingAssetBack());
                charName.text = dialog[currentDialogId].charName;
                texto.text = dialog[currentDialogId].text;
            }

            if (dialog[currentDialogId].idItem.Length == 1)
                if (dialog[currentDialogId].idItem[0] != "")
                    items[dialog[currentDialogId].idItem[0]] = true;

            if (dialog[currentDialogId].idItem.Length == 3)
                items[dialog[currentDialogId].idItem[currentInteraction]] = true;
        }

    }

    public IEnumerator LoadStreamingAssetChar()
    {
        string filePath = Application.streamingAssetsPath + GameManager.dialog[GameManager.currentDialogId].pathCharacter;
        WWW result = new WWW(filePath);

        while (!result.isDone)
        {
            yield return result;
        }

        materialChar.mainTexture = result.texture;
        yield return result;
    }

    public IEnumerator LoadStreamingAssetBack()
    {
        string filePath = Application.streamingAssetsPath + GameManager.dialog[GameManager.currentDialogId].pathScene;
        WWW result = new WWW(filePath);

        while (!result.isDone)
        {
            yield return result;
        }

        materialBack.mainTexture = result.texture;
        yield return result;
    }

}