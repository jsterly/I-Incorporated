using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;
using System.Text.RegularExpressions;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Events;
using Random = UnityEngine.Random;
using System.Linq;
using TMPro;

public class DaySummary : MonoBehaviour
{
    Canvas UICanvas;
    GameObject DaySummaryUI;
    RawImage TextBox;


    // Start is called before the first frame update
    void Start()
    {
        UICanvas = GameObject.Find("DaySummaryTxt").GetComponent<Canvas>();
        DaySummaryUI = UICanvas.transform.GetChild(0).GetComponent<GameObject>();
        TextBox = DaySummaryUI.transform.GetChild(0).GetComponent<RawImage>();
    }

    //This Coroutine is called when inflating or deflating a textbox over a given amount of time.
    IEnumerator ChangeSizeCoroutine(float time, float scale, RawImage textBox)
    {
        Vector3 originalScale = textBox.transform.localScale;
        Vector3 destinationScale = new Vector3(scale, scale, scale);

        float currentTime = 0.0f;

        do
        {
            textBox.transform.localScale = Vector3.Lerp(originalScale, destinationScale, currentTime / time);
            currentTime += Time.deltaTime;
            yield return null;
        } while (currentTime <= time);
        textBox.transform.localScale = destinationScale;
    }

    public void show_dialogue()
    {
        Debug.Log("HEY YOU!!!!!!");
        DaySummaryUI.SetActive(true);
        // UICanvas.GetComponentInChildren<TextMeshProUGUI>().text
        UICanvas.GetComponentInChildren<TextMeshProUGUI>().text = "Testing";
        Debug.Log("HEY!!!!!!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
