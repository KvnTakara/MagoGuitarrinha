using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage01_Environment : MonoBehaviour
{
    private void FixedUpdate()
    {
        if ( gameObject.tag == "Cloud")
        {
            transform.Translate(new Vector3(-0.1f * Time.deltaTime, 0, 0), Space.World);
        }

        if ( GameManager.instance.currentLevel < 5 )
        {
            if (transform.position.x < -15)
            {
                transform.position = new Vector3( 30, transform.position.y, transform.position.z );
            }
        }
    }
}
