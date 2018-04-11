using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputToString : MonoBehaviour
{

    public string playerName;
    public InputField input;
    public Text displayText;

    public void OnString_ToName()
    {
        playerName = input.text;
        displayText.text = playerName;
        Debug.Log("playerName variable now holds: " + playerName);
    }
}
