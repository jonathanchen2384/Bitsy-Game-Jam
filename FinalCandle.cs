using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalCandle : MonoBehaviour
{

    public GameObject DeathSensor;
    public float appearTime;
    private float duration;

    void Start()
    {
        gameObject.GetComponent<CircleCollider2D>().enabled = false;
        duration = appearTime;
        gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0);
    }

    void FixedUpdate()
    {
        if (DeathSensor.GetComponent<detectDeath>().RoyIsDead == true)
        {
            gameObject.GetComponent<CircleCollider2D>().enabled = true;
            poof();
        }
    }

    void poof()
    {
        if (duration <= 0)
        {
            gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
        }

        else
        {
            duration -= Time.deltaTime;
            gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1 - (duration / appearTime));
        }
    }

}
