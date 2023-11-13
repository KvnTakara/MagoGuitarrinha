using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGame : MonoBehaviour
{
    bool isGameOver = false;

    void Update()
    {
        if (GameManager.instance.currentLevel >= 7)
        {
            GetComponent<RawImage>().enabled = true;
            isGameOver = true;
        }

        if (Input.anyKeyDown && isGameOver)
        {
            //SceneManager.LoadScene(Menu);
        }
    }
}
