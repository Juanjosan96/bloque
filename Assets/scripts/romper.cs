using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class romper : MonoBehaviour {
    
    public GameObject efecto;
    public puntos puntos;
    
   
    
   
    void OnCollisionEnter(Collision colision)
    {
        if (colision.gameObject.CompareTag("bolita"))    //poner el script en el objeto a destruir y poner en tag lo que lo destruye
        {
            Debug.Log("choque");
            Destroy(gameObject);
            transform.SetParent(null);
            puntos.ganarpunto();
            Instantiate(efecto, transform.position, Quaternion.identity);
            
        }



    }
    






}
