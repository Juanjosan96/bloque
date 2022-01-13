using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class salir : MonoBehaviour
{
    public bool Salir;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Salir)
            {
                Debug.Log("adios");
                Application.Quit();
            }
            else
            {
                SceneManager.LoadScene("menu");
            }
        }
    }
}
