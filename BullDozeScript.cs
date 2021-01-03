using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullDozeScript : MonoBehaviour
{
    public GameObject RoyObj;
    public GameObject hitEffect;
    public float boomHieght;

    public float speed;
    public float verticalThreshold;
    public float chainHeight;

    public bool ready;
    public bool attack;
    public bool revert;

    void Start()
    {
        ready = true;
        attack = false;
        revert = false;
    }

    void FixedUpdate()
    {
        if (attack == true && revert == false)
        {
            ready = false;
            if (transform.position.y >= verticalThreshold && revert == false)
            {
                transform.Translate(Vector3.down * speed * Time.deltaTime, Space.World);
            }

            else
            {
                // attack Roy's Health
                Instantiate(hitEffect, new Vector3(0, boomHieght, 0), Quaternion.identity);
                RoyObj.GetComponent<RoyScript>().RoyHealth -= 1;
                attack = false;
                revert = true;
            }
        }

        if ( attack == false && revert == true)
        {
            if (transform.position.y <= chainHeight)
            {
                transform.Translate(Vector3.up * speed * Time.deltaTime, Space.World);
            }

            else
            {
                ready = true;
                revert = false;
            }
        }

    }
}
