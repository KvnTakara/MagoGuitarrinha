using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundEmitter : MonoBehaviour
{
    public GameObject emittingStage01;
    public GameObject emittingStage02;
    public GameObject emittingStage03;
    public GameObject emittingStage04;

    private void Update()
    {
        if ( transform.position.x <= -20 )
        {
            if (GameManager.instance.currentLevel < 2)
            {
                GameObject newGround = Instantiate(emittingStage01, new Vector3(20, transform.position.y, transform.position.z), Quaternion.Euler(30, 180, 0));
            }
            else if (GameManager.instance.currentLevel < 3)
            {
                GameObject newGround = Instantiate(emittingStage02, new Vector3(20, transform.position.y, transform.position.z), Quaternion.Euler(30, 180, 0));
            }
            else if (GameManager.instance.currentLevel < 4)
            {
                GameObject newGround = Instantiate(emittingStage03, new Vector3(20, transform.position.y, transform.position.z), Quaternion.Euler(30, 180, 0));
            }
            else if (GameManager.instance.currentLevel >= 4)
            {
                GameObject newGround = Instantiate(emittingStage04, new Vector3(20, transform.position.y, transform.position.z), Quaternion.Euler(30, 180, 0));
            }

            Destroy(gameObject);
        }
    }
}
