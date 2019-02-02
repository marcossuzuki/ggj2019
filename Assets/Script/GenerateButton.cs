using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GenerateButton : MonoBehaviour {

    public GameObject[] buttons;
    int current = -1;

    // Update is called once per frame
    private void FixedUpdate()
    {
        if(GameManager.loadConcluded)
        {
            if (current != GameManager.currentDialogId)
            {
                current = GameManager.currentDialogId;
                StartCoroutine(GenerateBt());
            }

            if (GameManager.dialog[GameManager.currentDialogId].id == 4 && GameManager.countInitialItems >= 3)
                if (!buttons[1].activeSelf)
                    buttons[1].SetActive(true);
        }
    }


    IEnumerator GenerateBt()
    {
        buttons[0].SetActive(false);
        buttons[1].SetActive(false);
        buttons[2].SetActive(false);

        int[] ids = GameManager.dialog[GameManager.currentDialogId].nextId;
        if (GameManager.dialog[GameManager.currentDialogId].decisions.Length == 1)
        {
            buttons[1].SetActive(true);
            buttons[1].GetComponent<Button>().onClick.RemoveAllListeners();
            buttons[1].GetComponent<Button>().onClick.AddListener(() => ChangeCurrent(ids[0]));
            buttons[1].GetComponent<Button>().GetComponentInChildren<Text>().text = GameManager.dialog[GameManager.currentDialogId].decisions[0];
            if(GameManager.dialog[GameManager.currentDialogId].id == 4)
                buttons[1].SetActive(false);

            yield return null;

            if (GameManager.dialog[GameManager.currentDialogId].id == 310)
            {
                buttons[1].GetComponent<Button>().onClick.RemoveAllListeners();
                buttons[1].GetComponent<Button>().onClick.AddListener(() => toTitleScene());
                buttons[1].GetComponent<Button>().GetComponentInChildren<Text>().text = "Title";
            }

        }
        else
        {
            buttons[0].SetActive(true);
            buttons[0].GetComponent<Button>().onClick.RemoveAllListeners();
            buttons[0].GetComponent<Button>().onClick.AddListener(() => ChangeCurrent(ids[0]));
            buttons[0].GetComponent<Button>().onClick.AddListener(() => ChangeCount(0));
            buttons[0].GetComponent<Button>().GetComponentInChildren<Text>().text = GameManager.dialog[GameManager.currentDialogId].decisions[0];

            buttons[1].SetActive(true);
            buttons[1].GetComponent<Button>().onClick.RemoveAllListeners();
            buttons[1].GetComponent<Button>().onClick.AddListener(() => ChangeCurrent(ids[1]));
            buttons[1].GetComponent<Button>().onClick.AddListener(() => ChangeCount(1));
            buttons[1].GetComponent<Button>().GetComponentInChildren<Text>().text = GameManager.dialog[GameManager.currentDialogId].decisions[1];

            buttons[2].SetActive(true);
            buttons[2].GetComponent<Button>().onClick.RemoveAllListeners();
            buttons[2].GetComponent<Button>().onClick.AddListener(() => ChangeCurrent(ids[2]));
            buttons[2].GetComponent<Button>().onClick.AddListener(() => ChangeCount(2));
            buttons[2].GetComponent<Button>().GetComponentInChildren<Text>().text = GameManager.dialog[GameManager.currentDialogId].decisions[2];

            yield return null;
        }
           
    }

    void ChangeCurrent(int c)
    {
        GameManager.currentDialogId = c;

    }

    void ChangeCount(int character)
    {
        GameManager.countInteraction[character]++;
        GameManager.currentInteraction = GameManager.countInteraction[character]-1;
        //Debug.Log(GameManager.countInteraction[0] + " " + GameManager.countInteraction[1] + " " + GameManager.countInteraction[2]);

    }


    void toTitleScene()
    {
        SceneManager.LoadScene("title");
    }

}
