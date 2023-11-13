using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Enemies : MonoBehaviour
{
    private Rigidbody rb;

    public float maxHealth;

    bool isEnemyReady = false;
    bool isEnemyDead = false;

    public GameObject librasEmitter;

    public TMP_Text enemieLifeText;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        // Setting Current Level Difficulty.
        if ( GameManager.instance.currentLevel == 1){ 
            maxHealth = 20;
            GameManager.instance.emitterSpeed = 2.5f;
            GameManager.instance.librasSpeed = 1f;
        } 
        else if (GameManager.instance.currentLevel == 2){
            maxHealth = 30;
            GameManager.instance.emitterSpeed = 2f;
            GameManager.instance.librasSpeed = 1f;
        }
        else if (GameManager.instance.currentLevel == 3){
            maxHealth = 40;
            GameManager.instance.emitterSpeed = 1.5f;
            GameManager.instance.librasSpeed = 1.5f;
        }
        else if (GameManager.instance.currentLevel == 4){
            maxHealth = 50;
            GameManager.instance.emitterSpeed = 1f;
            GameManager.instance.librasSpeed = 1.5f;
        }
        else if (GameManager.instance.currentLevel == 5){
            maxHealth = 60;
            GameManager.instance.emitterSpeed = 1f;
            GameManager.instance.librasSpeed = 1.25f;
        }
        else if (GameManager.instance.currentLevel == 6){
            maxHealth = 80;
            GameManager.instance.emitterSpeed = 0.85f;
            GameManager.instance.librasSpeed = 1.4f;
        }

        GameManager.instance.enemyLifePoints = maxHealth;
        enemieLifeText.text = GameManager.instance.enemyLifePoints.ToString() + " / " + maxHealth.ToString();
    }

    void Update()
    {
        // Updating Health Point Bar and calling destruction when it goes below zero.
        if (GameManager.instance.enemyLifePoints > 0)
        {
            enemieLifeText.text = GameManager.instance.enemyLifePoints.ToString() + " / " + maxHealth.ToString();
        } else { Destroy(enemieLifeText); }

        // Waiting for Enemy to get in Position so the scenario can stop moving.
        if (transform.position.x <= 6 && !isEnemyReady)
        {
            isEnemyReady = true;
            GameManager.instance.isWalking = false;

            // Instantiating Letter Emitter.
            GameObject enemieEmitter = Instantiate(librasEmitter, new Vector3(0, -6, 0), Quaternion.identity);
        }

        // Triggering the Elimination of the Enemy when HP is below zero.
        if (GameManager.instance.enemyLifePoints <= 0 )
        {
            // Locked by variable so it only triggers once.
            if ( !isEnemyDead )
            {
                isEnemyDead = true;

                // Changes stage configuration.
                GameManager.instance.currentLevel++;
                GameManager.instance.enemieDefeated = true;
                StartCoroutine ( EnemyDefeated() );
            }
        }
    }

    IEnumerator EnemyDefeated()
    {
        yield return new WaitForSeconds(1);

        // Add a Impulse against the Enemy Sprite after it is defeated.
        rb.freezeRotation = false;
        rb.AddForce(new Vector3(Random.Range(3f, 6f), Random.Range(3f, 4f), 0.3f), ForceMode.Impulse);

        yield return new WaitForSeconds(3);

        // Scenario starts moving again.
        GameManager.instance.isWalking = true;
        yield return new WaitForSeconds(6);

        // This Enemy object is destroyed.
        Destroy(gameObject);
    }
}
