using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public int health = 10;
    public Text text;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "DamageZone")
        {
            health = health - 4;
           Debug.Log("Kollision DamageZone findet statt");
            Destroy(collision.gameObject);
        }
        else
        {
            Debug.Log("Andere Kollision");
        
        }
        text.text = health.ToString();
    
    }
}
