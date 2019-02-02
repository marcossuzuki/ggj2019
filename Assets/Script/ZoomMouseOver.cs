using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomMouseOver : MonoBehaviour {


    public Vector3 originalScale;
    public Vector3 originalPosition;
    public int zoom;

    private void Start()
    {
        originalScale = gameObject.transform.localScale;
        originalPosition = gameObject.transform.localPosition;

    }


public void OnMouseEnter()
    {
        transform.localScale = originalScale * zoom;
        transform.localPosition =  new Vector3(originalPosition.x, originalPosition.y, 4);
    }

    public void OnMouseOver()
    {
        transform.localScale = originalScale * zoom;
        transform.localPosition = new Vector3(originalPosition.x, originalPosition.y, 4);
    }

    public void OnMouseExit()
    {
        transform.localScale = originalScale;
        transform.localPosition = originalPosition;
    }

}
