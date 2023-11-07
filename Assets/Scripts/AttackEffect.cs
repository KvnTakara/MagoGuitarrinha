using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackEffect : MonoBehaviour
{
    float speed = 0.02f;

    private void Update()
    {
        if (transform.position.x > 6 && transform.position.y <= -0.5 && transform.position.y >= -1.5)
        {
            Destroy(gameObject);
        }
    }

    private void FixedUpdate()
    {
        speed *= (speed + 1);

        if (transform.position.y > -1)
        {
            transform.Translate(speed * 0.75f, -speed * 2, 0);
        }

        if (transform.position.y < -1)
        {
            transform.Translate(speed * 0.75f, speed * 2, 0);
        }
    }
}
