using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SonidoONOFF : MonoBehaviour
{
    public bool sonidoActivado = true;
    public Sprite sonidoOn;
    public Sprite sonidoOff;
    public Image imagen;

    public void ActivarDesactivarSonido()
    {
        sonidoActivado = !sonidoActivado;

        if (sonidoActivado)
        {
            imagen.sprite = sonidoOn;
        }
        else
        {
            imagen.sprite = sonidoOff;
        }
    }
}
