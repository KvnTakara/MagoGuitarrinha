using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LibrasEmitter : MonoBehaviour
{
    public GameObject[] Lvl0;
    public GameObject[] Lvl1;
    public GameObject[] Lvl2;
    public GameObject[] Lvl3;
    public GameObject[] Lvl4;
    public GameObject[] Lvl5;

    public GameObject[] Libras;
    public GameObject[] newLibras;

    public float oldPositionX = 0;
    public float newPositionX = 0;

    void Start()
    {
        if (GameManager.instance.currentLevel == 0){Libras = Lvl0;}
        else if (GameManager.instance.currentLevel == 1){Libras = Lvl1;}
        else if (GameManager.instance.currentLevel == 2){Libras = Lvl2;}
        else if (GameManager.instance.currentLevel == 3){Libras = Lvl3;}
        else if (GameManager.instance.currentLevel == 4){Libras = Lvl4;}
        else if (GameManager.instance.currentLevel == 5){Libras = Lvl5;}

        newLibras = Libras;

        StartCoroutine( LetterGenerator( GameManager.instance.emitterSpeed ) );
    }

    private void Update()
    {
        if (GameManager.instance.enemieDefeated)
        {
            Destroy(gameObject);
        }
    }

    public void MoveX()
    {
        // Makes a minimum distance necessary of 2f between the last letters generated.
        do {
            newPositionX = Random.Range(-5f, 5f);
        } while (Mathf.Abs(newPositionX - oldPositionX) < 2f);
        oldPositionX = newPositionX;

        Vector3 newPosition = new Vector3( newPositionX, transform.position.y, transform.position.z );
        transform.position = newPosition;
    }

    IEnumerator LetterGenerator(float seconds)
    {
        MoveX();

        if (newLibras.Length == 0)
        {
            newLibras = Libras;
        }

        int randomIndex = Random.Range(0, newLibras.Length);
        GameObject randomObject = Instantiate(newLibras[randomIndex], transform.position, Quaternion.Euler(90, 180, 0));
        newLibras = RemoveObjectFromArray(newLibras, randomIndex);
        
        yield return new WaitForSeconds(seconds);

        StartCoroutine(LetterGenerator(GameManager.instance.emitterSpeed));
    }

    GameObject[] RemoveObjectFromArray(GameObject[] array, int index)
    {
        GameObject[] newArray = new GameObject[array.Length - 1];
        int newArrayIndex = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i != index)
            {
                newArray[newArrayIndex] = array[i];
                newArrayIndex++;
            }
        }
        return newArray;
    }
}
