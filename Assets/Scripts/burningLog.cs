using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class burningLog : MonoBehaviour
{
    public GameObject burningEffect;
    public GameObject ashEffect;

    private bool isBurnt;

    public float timer;

    void Start()
    {
        isBurnt = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isBurnt == true)
        {
            killSelf();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") || collision.CompareTag("Flame"))
        {
            Instantiate(burningEffect, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);

            isBurnt = true;
        }
    }


    private void killSelf()
    {
        if (timer <= 0)
        {
            Instantiate(ashEffect, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
            Destroy(gameObject);
        }

        else
        {
            timer -= Time.deltaTime;
        }
    }
}
