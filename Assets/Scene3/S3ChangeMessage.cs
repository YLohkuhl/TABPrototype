using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class S3ChangeMessage : MonoBehaviour
{
    public static string[] sceneMessageArray = new string[]
    {
        "",
        "Seems.. you beat the mini game.",
        "How about this-",
        "Oh.",
        "This? You mean my face?",
        "Seems you have the honor of seeing it.",
        "To show that.. I am slightly upset.",
        "This is my private area and you are bugging me.",
        "What are you? A robber.. in trying to click me?",
        "Look, if you leave now.. this won't get anymore serious.",
        "What will be your choice?",
        "Oh.",
        "Okay.",
        "Are you sure?",
        "The more you try to click me, the more I get the wrong message.",
        "Really?",
        "Come on.",
        "Pick the right choice.",
        "...",
        "...",
        "...",
        "Okay, okay, okay!",
        "I get your choice.",
        "As a warning though, you won't enjoy this.",
        "I want to make sure of that.."
    };

    private static TMP_Text sceneMessage;

    public int index = 0;

    public void Awake()
    {
        sceneMessage = transform.parent.parent.Find("Message").GetComponentInChildren<TMP_Text>();
    }

    public void ChangeText()
    {
        index++;

        if (index >= sceneMessageArray.Length)
        { SceneLoader.LoadScene("Clicking150"); }
        else
        { sceneMessage.text = sceneMessageArray[index]; }
    }
}
