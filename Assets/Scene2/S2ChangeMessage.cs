using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class S2ChangeMessage : MonoBehaviour
{
    public static string[] sceneMessageArray = new string[]
    {
        "",
        "How interesting..",
        "You're.. still going at it?",
        "How come?",
        "Is the curiosity that great?",
        "Want to get to the end?",
        "Seems I'll have to step it up a notch then.",
        "Did you know this game has no saves?",
        "Maybe ill give you a few if you prove yourself worthy.",
        "No, I'm not a ruler.",
        "Wait, did you even ask?",
        "Did I ask?",
        "Hm.. am I?",
        "Wanna listen to a story?",
        "Its a good one.",
        "Once upon a time..",
        "This person came into my room.",
        "They started trying to click me.",
        "I kept moving in random areas of my room.",
        "They just stayed trying to click.",
        "We played a little bit of a find the odd game.",
        "They still haven't left.",
        "And here we are.",
        "Did you get the message?",
        "Maybe.",
        "Hey, Siri.",
        "When will they leave?",
        "Totally Siri : Who knows.",
        "I know right.",
        "Hey, Alexa.",
        "Will they stop trying to click?",
        "Totally Alexa : Who knows.",
        "I know right.",
        "Oh.. do I last longer than the original? Good.",
        "What original? What?",
        "I'm just gonna go real quick, ill be back later.",
        "", // 1
        "", // 2
        "", // 3
        "", // 4
        "", // 5
        "", // 6
        "", // 7
        "", // 8
        "", // 9
        "", // 10
        "", // 11
        "", // 12
        "", // 13
        "", // 14
        "", // 15
        "", // 16
        "", // 17
        "", // 18
        "", // 19
        "", // 20
        "Alright, I'm back!",
        "Did you count how many times you tried clicking?",
        "Maybe.",
        "Lets see..",
        "Wanna play another game?",
        "No?",
        "You want me to take a nap first?",
        "Wow, thanks!",
        "Zzz..", // 1
        "Zzz..", // 2
        "Zzz..", // 3
        "Zzz..", // 4
        "Zzz..", // 5
        "Zzz..", // 6
        "Zzz..", // 7
        "Zzz..", // 8
        "Zzz..", // 9
        "Zzz..", // 10
        "Zzz..", // 11
        "Zzz..", // 12
        "Zzz..", // 13
        "Zzz..", // 14
        "Zzz..", // 15
        "Zzz..", // 16
        "Zzz..", // 17
        "Zzz..", // 18
        "Zzz..", // 19
        "Zzz..", // 20
        "Yawn..",
        "You know, you've been letting me sleep a lot.",
        "May feel nice if you did as well.",
        "So just leave.",
        "No?",
        "Why do you keep trying?",
        "...",
        "Okay.",
        "Let's play another game."
    };

    private static TMP_Text sceneMessage;

    public int index = 0;

    public void Awake()
    {
        sceneMessage = transform.Find("Message").GetComponentInChildren<TMP_Text>();
    }

    public void ChangeText()
    {
        index++;

        if (index >= sceneMessageArray.Length)
        { SceneLoader.LoadScene("Clicking50"); }
        else 
        { sceneMessage.text = sceneMessageArray[index]; }
    }
}
