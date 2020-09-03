using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pusher : MonoBehaviour
{
    private Vector3 origin;
    public Rigidbody rb;
    bool jugar = false;

    void Awake()
    {
        origin = rb.position;
        Invoke("Empezar", 1);
    }
    
    void Update()
    {
        if (jugar)
        {
            Vector3 offset = new Vector3(0, 0, 0.5f * Mathf.Sin(Time.time));
            rb.MovePosition(origin + offset);
        }
    }

    public void Empezar()
    {
        jugar = true;
    }
}
