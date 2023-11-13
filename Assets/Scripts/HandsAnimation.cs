using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandsAnimation : MonoBehaviour
{
    Animator animator;

    public bool handCooldown;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.anyKeyDown)
        {
            handCooldown = !handCooldown;
        }

        if (handCooldown && !GameManager.instance.isBlocked)
        {
            if ( Input.GetKeyDown(KeyCode.A))
            {
                animator.Play("Hand_A", -1);
            }
            if (Input.GetKeyDown(KeyCode.B))
            {
                animator.Play("Hand_B", -1);
            }
            if (Input.GetKeyDown(KeyCode.C))
            {
                animator.Play("Hand_C", -1);
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                animator.Play("Hand_D", -1);
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                animator.Play("Hand_E", -1);
            }
            if (Input.GetKeyDown(KeyCode.F))
            {
                animator.Play("Hand_F", -1);
            }
            if (Input.GetKeyDown(KeyCode.G))
            {
                animator.Play("Hand_G", -1);
            }
            if (Input.GetKeyDown(KeyCode.H))
            {
                animator.Play("Hand_H", -1);
            }
            if (Input.GetKeyDown(KeyCode.I))
            {
                animator.Play("Hand_I", -1);
            }
            if (Input.GetKeyDown(KeyCode.J))
            {
                animator.Play("Hand_J", -1);
            }
            if (Input.GetKeyDown(KeyCode.K))
            {
                animator.Play("Hand_K", -1);
            }
            if (Input.GetKeyDown(KeyCode.L))
            {
                animator.Play("Hand_L", -1);
            }
            if (Input.GetKeyDown(KeyCode.M))
            {
                animator.Play("Hand_M", -1);
            }
            if (Input.GetKeyDown(KeyCode.N))
            {
                animator.Play("Hand_N", -1);
            }
            if (Input.GetKeyDown(KeyCode.O))
            {
                animator.Play("Hand_O", -1);
            }
            if (Input.GetKeyDown(KeyCode.P))
            {
                animator.Play("Hand_P", -1);
            }
            if (Input.GetKeyDown(KeyCode.Q))
            {
                animator.Play("Hand_Q", -1);
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                animator.Play("Hand_R", -1);
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                animator.Play("Hand_S", -1);
            }
            if (Input.GetKeyDown(KeyCode.T))
            {
                animator.Play("Hand_T", -1);
            }
            if (Input.GetKeyDown(KeyCode.U))
            {
                animator.Play("Hand_U", -1);
            }
            if (Input.GetKeyDown(KeyCode.V))
            {
                animator.Play("Hand_V", -1);
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                animator.Play("Hand_W", -1);
            }
            if (Input.GetKeyDown(KeyCode.X))
            {
                animator.Play("Hand_X", -1);
            }
            if (Input.GetKeyDown(KeyCode.Y))
            {
                animator.Play("Hand_Y", -1);
            }
            if (Input.GetKeyDown(KeyCode.Z))
            {
                animator.Play("Hand_Z", -1);
            }
        } else if (handCooldown && GameManager.instance.isBlocked)
        {
            animator.Play("NoHand", -1);
        }

        if ( GameManager.instance.isWalking)
        {
            animator.Play("Hand", -1);
        }
    }
}
