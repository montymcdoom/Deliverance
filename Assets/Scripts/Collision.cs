using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 noPackageColor = new Color32(1, 1, 1, 1);

    bool hasPackage;
    [SerializeField] float destroyDelay = 0.5f;

    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

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
                spriteRenderer.color = hasPackageColor;
                Object.Destroy(other.gameObject, destroyDelay);
            }
        else if (other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Package delivered");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
    }

}
