using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormController : MonoBehaviour
{
    public int x;
    public string text;
    public float thrust = 1.0f;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rb.AddForce(transform.forward * thrust);
    }




    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("a"))
        {
            print("a key was pressed");
        }

    }


  
}
