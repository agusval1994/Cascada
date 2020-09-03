using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PonerFicha : MonoBehaviour
{
    public GameObject ficha;

    public GameObject pos1, pos2, pos3, pos4, pos5;

    public bool muchasFichas = false;

    void Update()
    {
        /*if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                if (hit.transform.gameObject.tag == "Ficha1")
                    CrearFicha(pos1);

                if (hit.transform.gameObject.tag == "Ficha2")
                    CrearFicha(pos2);

                if (hit.transform.gameObject.tag == "Ficha3")
                    CrearFicha(pos3);

                if (hit.transform.gameObject.tag == "Ficha4")
                    CrearFicha(pos4);

                if (hit.transform.gameObject.tag == "Ficha5")
                    CrearFicha(pos5);
            }
        }*/


        for (var i = 0; i < Input.touchCount; ++i)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
                if (Physics.Raycast(ray, out hit, 100.0f))
                {

                    if (hit.transform.gameObject.tag == "Ficha1")
                        CrearFicha(pos1);

                    if (hit.transform.gameObject.tag == "Ficha2")
                        CrearFicha(pos2);

                    if (hit.transform.gameObject.tag == "Ficha3")
                        CrearFicha(pos3);

                    if (hit.transform.gameObject.tag == "Ficha4")
                        CrearFicha(pos4);

                    if (hit.transform.gameObject.tag == "Ficha5")
                        CrearFicha(pos5);
                }
            }
        }
    }

    public void CrearFicha(GameObject pos)
    {
        if (muchasFichas == true)
        {
            for (int i = 0; i < 5; i++)
            {
                GameObject go = Instantiate(ficha, pos.transform.position, ficha.transform.rotation) as GameObject;
                go.transform.parent = this.transform;
            }
        }
        else
        {
            GameObject go = Instantiate(ficha, pos.transform.position, ficha.transform.rotation) as GameObject;
            go.transform.parent = this.transform;
        }
    }

    public void PonerMuchasFichas()
    {
        muchasFichas = !muchasFichas;
    }
}
