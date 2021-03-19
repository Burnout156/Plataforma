using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GerenciadorMenu : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Jogar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
