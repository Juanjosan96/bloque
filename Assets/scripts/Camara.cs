using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour {
    public GameObject bolita;
    public Vector3 posicionRelativa;
	// Use this for initialization
	void Start () {
        posicionRelativa = transform.position - bolita.transform.position;

	}
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = bolita.transform.position + posicionRelativa;
	}
}
