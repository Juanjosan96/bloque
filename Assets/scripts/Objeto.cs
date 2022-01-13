using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotacion1 : MonoBehaviour {
    Vector3 VelocidadRotacion = new Vector3(90, 45,90);
    // Use this for initialization
    void Start()
    {

    }
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(VelocidadRotacion * Time.deltaTime);
    
    }
}
