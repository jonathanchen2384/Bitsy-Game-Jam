using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleEndScript : MonoBehaviour
{
    public float deathTime;

    void Update()
    {
        Destroy(gameObject, deathTime);
    }
}
