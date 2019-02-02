using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class ActivateItens : MonoBehaviour {

    public Dictionary<String, bool> items = new Dictionary<string, bool>();

    public GameObject videogame;
    public GameObject plushie;
    public GameObject painting;
    public GameObject laptop;
    public GameObject book;
    public GameObject bed;
    public GameObject bureau;
    public GameObject sofa;
    public GameObject statuate;
    public GameObject catdog;
    public GameObject hatstand;
    public GameObject poster;
    public GameObject walkietalkie;
    public GameObject arcade;
    public GameObject plant;
    public GameObject onesie;
    public GameObject pillow;
    public GameObject wheelchair;


    private void Start()
    {
        InitializeItems();
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
        plushie.SetActive(items["PLUSHIE"]);
        videogame.SetActive(items["VIDEOGAME"]);
        painting.SetActive(items["PAINTING"]);
        laptop.SetActive(items["LAPTOP"]);
        book.SetActive(items["BOOK"]);
        bed.SetActive(items["BED"]);
        bureau.SetActive(items["BUREAU"]);
        sofa.SetActive(items["SOFA"]);
        statuate.SetActive(items["STATUATE"]);
        catdog.SetActive(items["CATDOG"]);
        hatstand.SetActive(items["HATSTAND"]);
        poster.SetActive(items["POSTER"]);
        walkietalkie.SetActive(items["WALKIETALKIE"]);
        arcade.SetActive(items["ARCADE"]);
        plant.SetActive(items["PLANT"]);
        onesie.SetActive(items["ONESIE"]);
        pillow.SetActive(items["PILLOW"]);
        wheelchair.SetActive(items["WHEELCHAIR"]);
    }


 
	
	// Update is called once per frame
	void Update () {

        if (items["PLUSHIE"] != GameManager.items["PLUSHIE"])
        {
            items["PLUSHIE"] = GameManager.items["PLUSHIE"];
            plushie.SetActive(items["PLUSHIE"]);
        }
        else if (items["VIDEOGAME"] != GameManager.items["VIDEOGAME"])
        {
            items["VIDEOGAME"] = GameManager.items["VIDEOGAME"];
            videogame.SetActive(items["VIDEOGAME"]);
        }
        else if (items["PAINTING"] != GameManager.items["PAINTING"])
        {
            items["PAINTING"] = GameManager.items["PAINTING"];
            painting.SetActive(items["PAINTING"]);
        }
        else if (items["LAPTOP"] != GameManager.items["LAPTOP"])
        {
            items["LAPTOP"] = GameManager.items["LAPTOP"];
            laptop.SetActive(items["LAPTOP"]);
        }
        else if (items["BOOK"] != GameManager.items["BOOK"])
        {
            items["BOOK"] = GameManager.items["BOOK"];
            book.SetActive(items["BOOK"]);
        }
        else if (items["BED"] != GameManager.items["BED"])
        {
            items["BED"] = GameManager.items["BED"];
            bed.SetActive(items["BED"]);
        }
        else if (items["BUREAU"] != GameManager.items["BUREAU"])
        {
            items["BUREAU"] = GameManager.items["BUREAU"];
            bureau.SetActive(items["BUREAU"]);
        }
        else if (items["SOFA"] != GameManager.items["SOFA"])
        {
            items["SOFA"] = GameManager.items["SOFA"];
            sofa.SetActive(items["SOFA"]);
        }
        else if (items["STATUATE"] != GameManager.items["STATUATE"])
        {
            items["STATUATE"] = GameManager.items["STATUATE"];
            statuate.SetActive(items["STATUATE"]);
        }
        else if (items["CATDOG"] != GameManager.items["CATDOG"])
        {
            items["CATDOG"] = GameManager.items["CATDOG"];
            catdog.SetActive(items["CATDOG"]);
        }
        else if (items["HATSTAND"] != GameManager.items["HATSTAND"])
        {
            items["HATSTAND"] = GameManager.items["HATSTAND"];
            hatstand.SetActive(items["HATSTAND"]);
        }
        else if (items["POSTER"] != GameManager.items["POSTER"])
        {
            items["POSTER"] = GameManager.items["POSTER"];
            poster.SetActive(items["POSTER"]);
        }
        else if (items["WALKIETALKIE"] != GameManager.items["WALKIETALKIE"])
        {
            items["WALKIETALKIE"] = GameManager.items["WALKIETALKIE"];
            walkietalkie.SetActive(items["WALKIETALKIE"]);
        }
        else if (items["ARCADE"] != GameManager.items["ARCADE"])
        {
            items["ARCADE"] = GameManager.items["ARCADE"];
            arcade.SetActive(items["ARCADE"]);
        }
        else if (items["PLANT"] != GameManager.items["PLANT"])
        {
            items["PLANT"] = GameManager.items["PLANT"];
            plant.SetActive(items["PLANT"]);
        }
        else if (items["ONESIE"] != GameManager.items["ONESIE"])
        {
            items["ONESIE"] = GameManager.items["ONESIE"];
            onesie.SetActive(items["ONESIE"]);
        }
        else if (items["PILLOW"] != GameManager.items["PILLOW"])
        {
            items["PILLOW"] = GameManager.items["PILLOW"];
            pillow.SetActive(items["PILLOW"]);
        }
        else if (items["WHEELCHAIR"] != GameManager.items["WHEELCHAIR"])
        {
            items["WHEELCHAIR"] = GameManager.items["WHEELCHAIR"];
            wheelchair.SetActive(items["WHEELCHAIR"]);
        }
    }
}
