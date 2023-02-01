using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Clicking50Transition : MonoBehaviour
{

    private static TMP_Text click50Text;
    public int clicks;

    public void Awake()
    {
        click50Text = GameObject.Find("Click50").GetComponentInChildren<TMP_Text>();
    }

    public void AddClickAmount()
    {
        clicks++;
        click50Text.text = "Current Attempts : " + clicks.ToString();
    }

    public void Update()
    {
        if (clicks >= 50)
        {
            SceneLoader.LoadScene("Scene3");
        }
    }
}
