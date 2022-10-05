using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndMagic : MonoBehaviour
{
    public GameObject CheckingHealth;
    public GameObject PoofEffect;

    void Update()
    {
        if (CheckingHealth.GetComponent<RoyScript>().RoyHealth <= 0)
        {
            Instantiate(PoofEffect, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
