using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainManager : MonoBehaviour
{

    public Text someText;

    public void ChangeTextRed()
    {
        someText.text = "you clicked a red cube!";
        Debug.Log("Working here Red!");
    }

    public void ChangeTextGreen()
    {
        someText.text = "you clicked a green sphere!";
        Debug.Log("Working here Green!");
    }

    public void ChangeTextBlue()
    {
        someText.text = "you clicked a blue capsule!";
        Debug.Log("Working here Blue!");
    }
}
