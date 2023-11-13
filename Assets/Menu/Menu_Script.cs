using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

using UnityEngine.SceneManagement;

public class Menu_Script : MonoBehaviour
{
    [SerializeField] public string namescene;
    [SerializeField] public string namescene2;
    [SerializeField] public bool painelCreditos = false;
    [SerializeField] public GameObject panielCre;
    // Start is called before the first frame update

    public void Play()
    {
       SceneManager.LoadScene(namescene);
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void Creditos()
    {
        painelCreditos = true;
        if(painelCreditos)
        {
            panielCre.SetActive(true);
        }
    }
    public void Volta()
    {
        if (painelCreditos)
        {
            painelCreditos = false;
            panielCre.SetActive(false);
        }
    }

    public void Desafio()
    {
        SceneManager.LoadScene("Desafio");
    }
}
