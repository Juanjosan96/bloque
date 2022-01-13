using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class empezarpartida : MonoBehaviour {

    public elementointeractivo pantallatactil;
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1")|| pantallatactil.pulsado)
        {
            puntos.Puntos = 0;
            vidas.Vidas = 3;
            SceneManager.LoadScene("nivel 1");
        }

	}
}
