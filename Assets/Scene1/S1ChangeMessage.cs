using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class S1ChangeMessage : MonoBehaviour
{
    public static string[] sceneMessageArray = new string[]
    {
        "",
        "What're you \ndoing here?",
        "Are you interested \nin my baking skills?",
        "Lovely day, isn't it?",
        "Why do I keep \nmoving around? Hm?",
        "Hey look its \na bird!",
        "What's your \nquestion?",
        "Nah I don't \nreally wanna know.",
        "Why is this game \nwritten differently from \nthe original?",
        "Are you in a game?",
        "Having fun?",
        "Getting tired of \nclicking?",
        "I'm gonna take a nap.",
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
        "Yawn..",
        "Are you done yet?",
        "Sorry I just.. \ncan't stay still.",
        "You're just gonna \nkeep clicking aren't you?",
        "Ow.. that was \nweak part.",
        "OW. STOP.",
        "lol just kidding",
        "I got a few games \nwe can play.",
        "I'll do those \nlater though.",
        "You like jazz?",
        "Nighty night.",
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
        "Yawn..",
        "Is there any point \nto this game?",
        "Wait is this \na game?",
        "You tell me.",
        "Getting bored? Good.",
        "Come on, keep going.",
        "Being an idiot.",
        "You just \nkeep pressing.",
        "Why?",
        "You okay?",
        "Am I okay?",
        "Hmm..",
        "A click.",
        "Per.",
        "Message.",
        "Must.",
        "Be.",
        "A",
        "N",
        "N",
        "O",
        "Y",
        "I",
        "N",
        "G",
        "Huh?",
        "Oh you sat \nthrough that?",
        "Interesting..",
        "Seems I have an \nactual challenger.",
        "About those games..",
        "Wanna start? \nGive me a minute.",
        "*Puts things together*", // 1
        "*Puts things together*", // 2
        "*Puts things together*", // 3
        "*Puts things together*", // 4
        "*Puts things together*", // 5
        "*Puts things together*", // 6
        "*Puts things together*", // 7
        "*Puts things together*", // 8
        "*Puts things together*", // 9
        "*Puts things together*", // 10
        "*Puts things together*", // 11
        "*Puts things together*", // 12
        "*Puts things together*", // 13
        "*Puts things together*", // 14
        "*Puts things together*", // 15
        "*Puts things together*", // 16
        "*Puts things together*", // 17
        "*Puts things together*", // 18
        "*Puts things together*", // 19
        "*Puts things together*", // 20
        "Alright, I'm ready!"
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
        { SceneLoader.LoadScene("OddFinding"); }
        else
        { sceneMessage.text = sceneMessageArray[index]; }
    }
}
