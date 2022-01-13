using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrita: MonoBehaviour
{
  
    Rigidbody rb;
    public float velocidad;
    public void Awake()
    {
        rb = GetComponent<Rigidbody>();

    }

    public void Update()
    {
       
        float MovimientoVertical = Input.GetAxis("Vertical");
        transform.localPosition += new Vector3(velocidad, 0, 0);
       

    }


}