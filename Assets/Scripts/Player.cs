using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    public TMP_Text playerLifeText;

    void Update()
    {
        playerLifeText.text = GameManager.instance.playerLifePoints.ToString() + " / " + GameManager.instance.playerMaxLifePoints.ToString();

        if ( GameManager.instance.isWalking) {
            playerLifeText.enabled = false;
        } else {
            playerLifeText.enabled = true;
        }
    }
}
