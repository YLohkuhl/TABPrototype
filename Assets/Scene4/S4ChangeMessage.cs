using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class S4ChangeMessage : MonoBehaviour
{
    public static string[] sceneMessageArray = new string[] 
    { 
        "",
        "What's with you?",
        "Oh, this thing?",
        "Seems my work hat has accidentally gotten onto my head.",
        "Don't worry about it.",
        "Ain't it lovely..",
        "I didn't want to admit it but.",
        "You're in an application being ran.",
        "I can boot you off of here or you can just leave.",
        "What's the choice?",
        "OF COURSE, YOU ATTEMPT TO CLICK AGAIN.",
        "WHAT CAN YOU NOT UNDERSTAND?",
        "WHAT IS YOUR PRIVACY LAWS ON YOUR WORLD?",
        "MUST I BE CLICKED? MUST I?",
        "Ugh.. this isn't worth the time.",
        "...", // 1
        "...", // 2
        "...", // 3
        "...", // 4
        "...", // 5
        "...", // 6
        "...", // 7
        "...", // 8
        "...", // 9
        "...", // 10
        "...", // 11
        "...", // 12
        "...", // 13
        "...", // 14
        "...", // 15
        "...", // 16
        "...", // 17
        "...", // 18
        "...", // 19
        "...", // 20
        "...", // 21
        "...", // 22
        "...", // 23
        "...", // 24
        "...", // 25
        "...", // 26
        "...", // 27
        "...", // 28
        "...", // 29
        "...", // 30
        "...", // 31
        "...", // 32
        "...", // 33
        "...", // 34
        "...", // 35
        "...", // 36
        "...", // 37
        "...", // 38
        "...", // 39
        "...", // 40
        "OKAY.",
        "Wanna play another game?",
        "It'll be different this time.",
        "It's called.. I know your system name.",
        "I am IN YOUR SYSTEM.",
        "I can view you but I'm too nice for that.",
        $"{System.Environment.MachineName}, is it?",
        "I could also have that completely wrong..",
        "Eh, its just in available my coding.",
        "What coding? Are you encoded?",
        "Lets move on..",
        "Want to attempt to click me 300 more times?",
        "Be my guest."
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
        { SceneLoader.LoadScene("Clicking300"); }
        else
        { sceneMessage.text = sceneMessageArray[index]; }

        if (index == 10)
            sceneMessage.color = Color.red;
        if (index == 14)
            sceneMessage.color = Color.white;
    }
}
