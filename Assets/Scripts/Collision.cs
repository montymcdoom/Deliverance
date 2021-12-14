using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    bool hasPackage;
    [SerializeField] float destroyDelay = 0.5f;
    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("Ow! Drive more carefully!");
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && !hasPackage)
            {
                Debug.Log("Package collected");
                hasPackage = true;
                Object.Destroy(other.gameObject, destroyDelay);
            }
        else if (other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Package delivered");
            hasPackage = false;
        }
    }

}
