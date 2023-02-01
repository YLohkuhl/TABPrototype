using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonChoiceScript : MonoBehaviour
{
    public void BackToMain()
    {
        SceneLoader.LoadScene("MainMenu");
    }

    public void BackToMainSave()
    {
        PlayerPrefs.SetInt("SavedSceneIndex", SceneManager.GetActiveScene().buildIndex);
        PlayerPrefs.Save();
        SceneLoader.LoadScene("MainMenu");
    }
}
