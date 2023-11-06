using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissedLetter : MonoBehaviour
{
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
        animator.Play("Missed_" + GameManager.instance.missedLetter, -1);
        StartCoroutine(destruction());
    }

    IEnumerator destruction()
    {
        yield return new WaitForSeconds(3);

        Destroy(gameObject);
    }
}
