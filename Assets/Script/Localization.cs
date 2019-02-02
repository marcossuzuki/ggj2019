using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Localization : MonoBehaviour {

    public static Localization instance = null;
    public static string fileName = "ptbr.json";
    //public static Dialog dialog = new Dialog();
   

    void Start()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);


        DontDestroyOnLoad(this);
    }
}
