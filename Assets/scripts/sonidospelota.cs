using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonidospelota : MonoBehaviour
{
    public AudioSource Rebote;
    public AudioSource Punto;
    
   
    void OnCollisionEnter(Collision otro)
    {
        if (otro.gameObject.CompareTag("bloques"))
        {
            Punto.Play();
        }
         if (otro.gameObject.CompareTag("estructura"))
        {

        }
        
        else
        {
            otro.gameObject.CompareTag("barra");

            Rebote.Play();
        }
       
    }
}