using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyScript : MonoBehaviour
{
    private float timeLeft;

    private void Start()
    {
        timeLeft = 1f;
    }

    void FixedUpdate()
    {
        if (timeLeft <= 0)
        {
            Destroy(gameObject);
        }

        else
        {
            timeLeft -= Time.deltaTime;
        }
    }
}
