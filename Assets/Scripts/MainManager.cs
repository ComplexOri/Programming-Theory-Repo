using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainManager : MonoBehaviour
{
    private static int health;
    public Text someText;
    
    public static int Health
    {
    get { return health; }
    set { health = value; health = 1; }
    }

    public static void TakeDMG ()
    {
        health--;
        if(health <= 0)
        {
            Die();
        }
    }

    public static void Die()
    {
        SceneManager.LoadScene(0);
    }

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