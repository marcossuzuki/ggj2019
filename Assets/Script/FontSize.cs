using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FontSize : MonoBehaviour {

    public Text textDialog;


    public void IncreaseFont()
    {
        if (textDialog.fontSize<=32)
            textDialog.fontSize += 1;
    }

    public void DecreaseFont()
    {
        if (textDialog.fontSize >= 7)
            textDialog.fontSize -= 1;
    }
}
