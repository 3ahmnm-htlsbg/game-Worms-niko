using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormController : MonoBehaviour
{
    public int x;
    public string text;

    // Start is called before the first frame update
    void Start()

    {
        if (x > 0)
        {
            Debug.Log("x ist größer als null");
        }
        else
        {
            Debug.Log("x ist kleiner gleich null");
        }

    }



    // Update is called once per frame
    void Update()
    {

    }


    public float AddNumbers(float a, float b)
    {
        float c = a + b;
        return c;
    }
}
