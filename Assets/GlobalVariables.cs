using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public static class GlobalVariables
{
    public static string versionNumber = GameObject.Find("Version").GetComponentInChildren<TMP_Text>().text;
}
