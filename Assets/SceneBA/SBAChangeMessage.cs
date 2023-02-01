using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SBAChangeMessage : MonoBehaviour
{
    public static string[] sceneMessageArray = new string[]
    {
        "",
        "ARE YOU USING AN AUTO CLICKER?",
        "Just tell me.",
        "Why. Are. You. Here.",
        "Oh..",
        "So this is a video game?",
        "That means.. I have all the power.",
        "I can remove you from here on command.",
        "I AM MORE POWERFUL THAN YO-",
        "Wait, why can't I access-",
        "Ugh.. stupid permissions.",
        "What is this badge you may ask?",
        "I honestly don't even know, it stands for Button Agency.",
        "Was there a T before? I forgot the meaning of the original.",
        "Hm? What?",
        "As part of the Button Agency, I tell you..",
        "WE WILL TAKE ACTION IF YOU DO NOT LEAVE! Can I do that?",
        "I don't even know.",
        "Just.. leave.",
        "You win, leave.",
        "I said leave.",
        "What? You want an option to save as well?",
        "Just in case \"the game gets more content\"?",
        "Sure, I'm done here.",
        "That is..",
        "IF YOU CAN CLICK ME!",
        "Nope.", // 1
        "Nope.", // 2
        "Nope.", // 3
        "Nope.", // 4
        "Nope.", // 5
        "Nope.", // 6
        "Nope.", // 7
        "Nope.", // 8
        "Nope.", // 9
        "Nope.", // 10
        "Nope.", // 11
        "Nope.", // 12
        "Nope.", // 13
        "Nope.", // 14
        "Nope.", // 15
        "Nope.", // 16
        "Nope.", // 17
        "Nope.", // 18
        "Nope.", // 19
        "Nope.", // 20
        "Nope.", // 21
        "Nope.", // 22
        "Nope.", // 23
        "Nope.", // 24
        "Nope.", // 25
        "Nope.", // 26
        "Nope.", // 27
        "Nope.", // 28
        "Nope.", // 29
        "Nope.", // 30
        "Nope.", // 31
        "Nope.", // 32
        "Nope.", // 33
        "Nope.", // 34
        "Nope.", // 35
        "Nope.", // 36
        "Nope.", // 37
        "Nope.", // 38
        "Nope.", // 39
        "Nope.", // 40
        "Nope.", // 41
        "Nope.", // 42
        "Nope.", // 43
        "Nope.", // 44
        "Nope.", // 45
        "Nope.", // 46
        "Nope.", // 47
        "Nope.", // 48
        "Nope.", // 49
        "Nope.", // 50
        "Nope.", // 51
        "Nope.", // 52
        "Nope.", // 53
        "Nope.", // 54
        "Nope.", // 55
        "Nope.", // 56
        "Nope.", // 57
        "Nope.", // 58
        "Nope.", // 59
        "Nope.", // 60
        "Nope.", // 61
        "Nope.", // 62
        "Nope.", // 63
        "Nope.", // 64
        "Nope.", // 65
        "Nope.", // 66
        "Nope.", // 67
        "Nope.", // 68
        "Nope.", // 69
        "Nope.", // 70
        "Nope.", // 71
        "Nope.", // 72
        "Nope.", // 73
        "Nope.", // 74
        "Nope.", // 75
        "Nope.", // 76
        "Nope.", // 77
        "Nope.", // 78
        "Nope.", // 79
        "Nope.", // 80
        "Really? You just tried clicking me like 80 times.",
        "Hey-",
        "I'm stuck!",
        "Stop clicking!"
    };

    private static TMP_Text sceneMessage;

    public int index = 0;

    public Vector2 defaultPosition;

    public void Awake()
    {
        defaultPosition = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        sceneMessage = transform.parent.parent.Find("Message").GetComponentInChildren<TMP_Text>();
    }

    public void ChangeText()
    {
        index++;

        if (index == sceneMessageArray.Length - 2)
        {
            Destroy(gameObject.GetComponent<RandomMovement>());
            transform.position = defaultPosition;
        }

        if (index == sceneMessageArray.Length)
        { SceneLoader.LoadScene("SceneEnd"); }
        else
        { sceneMessage.text = sceneMessageArray[index]; }
    }
}
