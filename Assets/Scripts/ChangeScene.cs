using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void SceneTransfer()
    {
        SceneManager.LoadScene(1);
    }
}
