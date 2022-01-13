using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonidosfinpartida : MonoBehaviour {
    public AudioSource audiosource;
    public AudioClip completado;
    public AudioClip GameOver;
    public AudioClip volumen;
    
    public void gameOver()
    {
        reproducesonido(GameOver);
    }
   
  
    public void NivelCompletado()
    {
        reproducesonido(completado);
    }
    void reproducesonido(AudioClip sonido)
    {
        audiosource.clip = sonido;
        audiosource.loop = false;
        audiosource.Play();
    }
  
}


