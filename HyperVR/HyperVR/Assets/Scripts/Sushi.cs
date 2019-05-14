using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sushi : MonoBehaviour
{
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Grab(){
        rb.isKinematic = true;
    }

    public void Release(){
        rb.isKinematic = false;
    }
}
