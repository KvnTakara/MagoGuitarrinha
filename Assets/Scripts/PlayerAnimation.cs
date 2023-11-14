using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    public Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (GameManager.instance.isBlocked)
        {
            animator.SetBool("isBlocked", true);
        } else
        {
            animator.SetBool("isBlocked", false);
        }
    }
}
