using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesAnimation : MonoBehaviour
{
    Animator animator;
    bool isAlive = true;

    void Start()
    {
        animator = GetComponent<Animator>();

        if (GameManager.instance.currentLevel == 0)
        {
            animator.Play("Minion_01", -1);
        }
        else if (GameManager.instance.currentLevel == 1)
        {
            animator.Play("Minion_02", -1);
        }
        else if (GameManager.instance.currentLevel == 2)
        {
            animator.Play("Minion_03", -1);
        }
        else if (GameManager.instance.currentLevel == 3)
        {
            animator.Play("Minion_03", -1);
        }
        else if (GameManager.instance.currentLevel == 4)
        {
            animator.Play("Minion_03", -1);
        }
        else if (GameManager.instance.currentLevel == 5)
        {
            animator.Play("Minion_03", -1);
        }
    }

    void Update()
    {
        if ( GameManager.instance.miss )
        {
            animator.Play("Minion_03_attack", -1);
        }

        if (isAlive && transform.rotation.x != 0 || transform.rotation.x != 0 || transform.rotation.x != 0)
        {
            if (GameManager.instance.currentLevel == 1)
            {
                isAlive = false;
                animator.Play("Minion_01_dead", -1);
            } else if (GameManager.instance.currentLevel == 2)
            {
                isAlive = false;
                animator.Play("Minion_02_dead", -1);
            } else if (GameManager.instance.currentLevel == 3)
            {
                isAlive = false;
                animator.Play("Minion_03_dead", -1);
            } else if (GameManager.instance.currentLevel == 4)
            {
                isAlive = false;
                animator.Play("Minion_03_dead", -1);
            } else if (GameManager.instance.currentLevel == 5)
            {
                isAlive = false;
                animator.Play("Minion_03_dead", -1);
            } else if (GameManager.instance.currentLevel == 6)
            {
                isAlive = false;
                animator.Play("Minion_03_dead", -1);
            }
        }
    }
}
