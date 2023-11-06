using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int currentLevel = 0;

    public float playerLifePoints;
    public float playerMaxLifePoints = 10;
    public GameObject fadeObject;

    public bool enemieDefeated = true;
    public float enemyLifePoints;

    public float emitterSpeed = 2;
    public float librasSpeed;

    public bool isWalking = true;
    public bool miss;
    public string missedLetter;

    public GameObject enemie;

    void Start()
    {
        // Turn object into Singleton.
        if (instance == null)
        {
            instance = this;
        } else { Destroy(gameObject); }

        playerLifePoints = playerMaxLifePoints;
    }

    void Update()
    {
        if (enemieDefeated)
        {
            playerLifePoints = playerMaxLifePoints;
            enemieDefeated = false;
            SpawnEnemie();
        }

        if (miss)
        {
            miss = false;
            Miss();
        }
    }

    void SpawnEnemie()
    {
        GameObject newEnemie = Instantiate(enemie, new Vector3(30, -1, 13), Quaternion.identity);
    }

    void Miss()
    {
        playerLifePoints--;
    }
}
