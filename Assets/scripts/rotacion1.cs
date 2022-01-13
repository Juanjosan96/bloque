using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotacion : MonoBehaviour {
    Vector3 VelocidadRotacion = new Vector3(0,0, 0);
	// Use this for initialization
	void Start () {
        int prueba = 50;
        Debug.Log(prueba);
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(VelocidadRotacion * Time.deltaTime);
    }
}
