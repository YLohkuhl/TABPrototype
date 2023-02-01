using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovement : MonoBehaviour
{
    public static GameObject buttonChar;

    public void Awake()
    {
        buttonChar = transform.parent.gameObject;
    }
    
    public void MoveButton()
    {
        buttonChar.transform.position = new Vector2(Random.Range(0, Screen.width), Random.Range(0, Screen.height));
    }
}
