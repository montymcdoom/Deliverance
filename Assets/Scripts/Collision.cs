using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    bool hasPackage;

    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("Ow! Drive more carefully!");
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package")
            {
                Debug.Log("Package collected");
                hasPackage = true;
            }
        else if (other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Package delivered");
            hasPackage = false;
        }
    }

}
