using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class elementointeractivo :MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    public bool pulsado;
    public bool Prueba;
    public void OnPointerDown(PointerEventData eventData)
    {
        pulsado = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        pulsado = false;
    }




   
    
}
