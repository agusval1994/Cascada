using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Moneda : MonoBehaviour
{
    public AudioSource[] fichas;
    float posInicial;
    private SonidoONOFF sonido;
    public Button goSonido;

    void Start()
    {
        posInicial = transform.position.y;
        sonido = GameObject.FindObjectOfType<SonidoONOFF>();
    }

    public void OnCollisionEnter(Collision collision)
    {
        float nuevaPos = transform.position.y;

        if (posInicial - nuevaPos > 0.4f)
        {
            posInicial = nuevaPos;

            if (sonido.sonidoActivado)
            {
                SonidoRandom();
            }
        }
    }

    public void SonidoRandom()
    {
        int random = Random.Range(0, fichas.Length);
        AudioSource sonido = fichas[random];
        sonido.Play();
    }
}
