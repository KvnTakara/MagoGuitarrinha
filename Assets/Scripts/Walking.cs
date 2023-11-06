using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Walking : MonoBehaviour
{
    private void FixedUpdate()
    {
        if (GameManager.instance.isWalking)
        {
            transform.Translate(new Vector3(-2 * Time.deltaTime, 0, 0), Space.World);
        }

        if (transform.position.x < -25)
        {
            Destroy( gameObject );
        }
    }
}
