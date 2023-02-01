using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Clicking300Transition : MonoBehaviour
{

    private static TMP_Text click300Text;
    public int clicks;

    public void Awake()
    {
        click300Text = GameObject.Find("Click300").GetComponentInChildren<TMP_Text>();
    }

    public void AddClickAmount()
    {
        clicks++;
        click300Text.text = "Current Attempts : " + clicks.ToString();
    }

    public void Update()
    {
        if (clicks >= 300)
        {
            SceneLoader.LoadScene("SceneBA");
        }
    }
}
