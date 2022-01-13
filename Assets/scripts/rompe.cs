using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rompe : MonoBehaviour {
    public GameObject efecto;
    public puntos puntos;

   
    void OnCollisionEnter(Collision colision)
    { Destroy(gameObject);
        Instantiate(efecto,transform.position,Quaternion.identity);
       
        transform.SetParent(null);
        puntos.ganarpunto();
       
    }
}
