using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    bool isGameOver = false;

    void Update()
    {
        if (GameManager.instance.playerLifePoints <= 0)
        {
            GetComponent<RawImage>().enabled = true;
            isGameOver = true;
            Time.timeScale = 0;
        }

        if (Input.GetKeyDown(KeyCode.Escape) && isGameOver)
        {
            //SceneManager.LoadScene(Menu);
        }
    }
}
