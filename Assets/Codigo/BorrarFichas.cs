using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorrarFichas : MonoBehaviour
{
    private ManagerPuntos manager;
    public GameObject goManager;

    void Start()
    {
        manager = goManager.GetComponent<ManagerPuntos>();
    }

    public void OnCollisionEnter(Collision collision)
    {
        manager.SumaPuntos();
        Destroy(collision.gameObject);
    }
}
