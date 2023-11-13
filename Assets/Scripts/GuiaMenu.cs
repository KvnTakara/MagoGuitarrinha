using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GuiaMenu : MonoBehaviour
{
    public GameObject GuiaPanel;
    public int lvlGuia;
    bool isPaused;
    bool triggerGuia = true;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !isPaused)
        {
            OpenGuia();
            isPaused = true;
        }
        else if (Input.GetKeyDown(KeyCode.Backspace))
        {
            SceneManager.LoadScene("Menu");
        }
        else if (Input.anyKeyDown && isPaused)
        {
            CloseGuia();
            isPaused = false;
        }

        if (GameManager.instance.callGuia && triggerGuia)
        {
            if (GameManager.instance.currentLevel == lvlGuia)
            {
                GameManager.instance.callGuia = false;
                triggerGuia = false;

                OpenGuia();
                isPaused = true;
            }
        }
    }

    public void OpenGuia()
    {
        if (GameManager.instance.currentLevel == lvlGuia)
        {
            GuiaPanel.GetComponent<RawImage>().enabled = true;
            Time.timeScale = 0;
        }
    }

    public void CloseGuia()
    { 
        GuiaPanel.GetComponent<RawImage>().enabled = false; 
        Time.timeScale = 1;
    }
}
