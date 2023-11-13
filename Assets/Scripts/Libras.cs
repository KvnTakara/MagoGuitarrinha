using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Libras : MonoBehaviour
{
    public KeyCode keyToDestroy;
    public GameObject letter;
    public GameObject attack;
    public string missedletter;

    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true;
    }

    void Update()
    {
        if (GameManager.instance.enemieDefeated)
        {
            Destroy(gameObject);
        }

        if ( Input.GetKeyDown( keyToDestroy ) && !GameManager.instance.isBlocked )
        {
            GameManager.instance.enemyLifePoints--;
            GameManager.instance.missTyping = 4;
            GameObject attackEffect = Instantiate(attack, transform.position, Quaternion.identity);
            Destroy( gameObject );
        }

        if ( transform.position.y >= 4 )
        {
            GameManager.instance.miss = true;
            GameManager.instance.missedLetter = missedletter;
            GameObject missedLetter = Instantiate(letter, transform.position, Quaternion.identity);
            Destroy( gameObject );
        }

        if ( GameManager.instance.miss )
        {
            GameManager.instance.missTyping = 4;
            GameManager.instance.isBlocked = false;
            rb.isKinematic = false;
            rb.AddForce(Vector3.down,ForceMode.Impulse);
            StartCoroutine(DestroyMiss());
        }
    }

    private void FixedUpdate()
    {
        transform.Translate(0, 0, -GameManager.instance.librasSpeed * Time.deltaTime);
    }

    IEnumerator DestroyMiss()
    {
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
    }
}
