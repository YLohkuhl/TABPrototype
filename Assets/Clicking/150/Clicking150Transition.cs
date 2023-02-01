using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Clicking150Transition : MonoBehaviour
{

    private static TMP_Text click150Text;
    public int clicks;

    public void Awake()
    {
        click150Text = GameObject.Find("Click150").GetComponentInChildren<TMP_Text>();
    }

    public void AddClickAmount()
    {
        clicks++;
        click150Text.text = "Current Attempts : " + clicks.ToString();
    }

    public void Update()
    {
        if (clicks >= 150)
        {
            SceneLoader.LoadScene("OddFinding2");
        }
    }
}
