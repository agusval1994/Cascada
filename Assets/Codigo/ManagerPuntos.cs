using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerPuntos : MonoBehaviour
{
    public int best = 0;
    public int puntaje = 0;

    public Text texto_best;
    public Text texto_puntaje;

    void Awake()
    {
        best = PlayerPrefs.GetInt("Best");
        texto_best.text = best.ToString();
        texto_puntaje.text = puntaje.ToString();
    }

    public void SumaPuntos()
    {
        puntaje++;
        texto_puntaje.text = puntaje.ToString();

        if (puntaje > best)
        {
            best = puntaje;
            texto_best.text = best.ToString();
        }
    }

    private void OnApplicationQuit()
    {
        PlayerPrefs.SetInt("Best", best);
    }
}
