using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class suelo : MonoBehaviour {
    public vidas Vidas;
    public GameObject habilidad1;
   

    void OnTriggerEnter(Collider otro){
        if (otro.gameObject.CompareTag("habilidad"))
        {

            
        }
        else {
            
            Vidas.perdervida();
        }
       

    }
    
        
    

}
