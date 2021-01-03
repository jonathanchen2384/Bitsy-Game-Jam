using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectDeath : MonoBehaviour
{
    public bool RoyIsDead;

    private void Start()
    {
        RoyIsDead = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Roy"))
        {
            RoyIsDead = true;
        }
    }
}
