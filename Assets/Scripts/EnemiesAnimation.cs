using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemiesAnimation : MonoBehaviour
{
    Animator animator;
    bool isAlive = true;

    void Start()
    {
        animator = GetComponent<Animator>();

        if (GameManager.instance.currentLevel == 1)
        {
            animator.Play("Minion_01");
        }
        else if (GameManager.instance.currentLevel == 2)
        {
            animator.Play("Minion_02");
        }
        else if (GameManager.instance.currentLevel == 3)
        {
            animator.Play("Minion_03");
        }
        else if (GameManager.instance.currentLevel == 4)
        {
            animator.Play("Minion_04");
        }
        else if (GameManager.instance.currentLevel == 5)
        {
            animator.Play("Minion_05");
        }
        else if (GameManager.instance.currentLevel == 6)
        {
            animator.Play("Minion_06");
        }
    }

    void Update()
    {
        if (isAlive && transform.rotation.x != 0 || transform.rotation.x != 0 || transform.rotation.x != 0)
        {
            if (GameManager.instance.currentLevel == 2)
            {
                isAlive = false;
                animator.Play("Minion_01_dead");
            } else if (GameManager.instance.currentLevel == 3)
            {
                isAlive = false;
                animator.Play("Minion_02_dead");
            } else if (GameManager.instance.currentLevel == 4)
            {
                isAlive = false;
                animator.Play("Minion_03_dead");
            } else if (GameManager.instance.currentLevel == 5)
            {
                isAlive = false;
                animator.Play("Minion_04_dead");
            } else if (GameManager.instance.currentLevel == 6)
            {
                isAlive = false;
                animator.Play("Minion_05_dead");
            } else if (GameManager.instance.currentLevel == 7)
            {
                isAlive = false;
                animator.Play("Minion_06_dead");
            }
        }
    }
}
