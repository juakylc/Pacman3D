using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class S_Menu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Game");
    }

    public void Options()
    {
        SceneManager.LoadScene("Options");
    }

    public void Exit()
    {
        SceneManager.LoadScene("Main");
    }
}
