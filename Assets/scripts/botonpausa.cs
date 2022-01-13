using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class botonpausa : MonoBehaviour
{


    public class Example : MonoBehaviour
    {
        public static Touch GetTouch;
        public void Update()
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Debug.Log(Input.mousePosition);
            }
        }
    }
}




