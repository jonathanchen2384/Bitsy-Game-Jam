using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chainScript : MonoBehaviour
{
    public GameObject bullDozer;

    public float startingTime;
    public float Speed;
    private bool chainUp;

    void Start()
    {
        chainUp = false;
    }

    void FixedUpdate()
    {
        if (chainUp == true)
        {
            chainMoveOnTime();
        }

        if (transform.position.y >= 7)
        {
            Destroy(gameObject, 2f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") || collision.CompareTag("Flame"))
        {
            if (bullDozer.GetComponent<BullDozeScript>().ready == true && bullDozer.GetComponent<BullDozeScript>().revert == false)
            {
                bullDozer.GetComponent<BullDozeScript>().attack = true;
                chainUp = true;
            }
        }
    }

    private void chainMoveOnTime()
    {
        if (startingTime <= 0)
        {
            transform.Translate(Vector3.up * Speed * Time.deltaTime, Space.World);
        }

        else
        {
            startingTime -= Time.deltaTime;
        }
    }
}
