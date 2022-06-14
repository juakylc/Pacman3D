using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class S_options : MonoBehaviour
{
    public Slider slider;

    public void Volume()
    {
        AudioListener.volume = slider.value;
    }

    public void Back()
    {
        SceneManager.LoadScene("Menu");
    }
}
