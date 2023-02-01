using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void ExitGame()
    {
        Application.Quit();
    }

    public void LoadGame()
    {
        if (PlayerPrefs.GetInt("SavedSceneIndex") != 0)
        {
            SceneLoader.LoadSceneIndex(PlayerPrefs.GetInt("SavedSceneIndex"));
        } else
        {
            GameObject.Find("HonkSound").GetComponentInChildren<AudioSource>().Play();
            return;
        }
    }
}
