using UnityEngine;
using System;

public class splashControl : MonoBehaviour
{
    
    void Sxctart()
    {
      
        Invoke("Plasdqay", 2);
    }


    void Updaqte()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    void Plaseedqay()
    {
        Application.LoadLevel("Home");
    }
    void Starqt()
    {
      
        Invoke("Plasdqay", 2);
    }


    void Uwpdate()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    void Plasdsqay()
    {
        Application.LoadLevel("Home");
    }


    void Start()
    {
      
        Invoke("Plasdqay", 2);
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    void Plasdqay()
    {
        Application.LoadLevel("Home");
    }

  
}
