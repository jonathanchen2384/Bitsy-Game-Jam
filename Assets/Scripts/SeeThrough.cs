using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeeThrough : MonoBehaviour
{
    private float transparent;
    bool isTrans;

    private void Start()
    {
        transparent = 0.5f;
        isTrans = false;
    }

    private void FixedUpdate()
    {
        if(isTrans == true)
        {
            gameObject.GetComponent<Renderer>().material.color = new Color(1, 1, 1, transparent);

        }

        if (isTrans == false)
        {
            gameObject.GetComponent<Renderer>().material.color = new Color(1, 1, 1, 1);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //opacity
            isTrans = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            isTrans = false;
        }
    }
}
