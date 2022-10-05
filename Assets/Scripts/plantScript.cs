using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plantScript : MonoBehaviour
{
    public GameObject fireEffect;
    public GameObject Smoke;

    private bool isDead;
    private float timeLeft;

    void Start()
    {
        isDead = false;
        timeLeft = 2f;
    }

    private void Update()
    {
        if (isDead == true)
        {
            plantDeath();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") || collision.CompareTag("Flame")) {

            Instantiate(fireEffect, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);

            isDead = true;
        }
    }


    private void plantDeath()
    {
        if (timeLeft <= 0)
        {
            Instantiate(Smoke, new Vector3( transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
            Destroy(gameObject);
        }

        else
        {
            timeLeft -= Time.deltaTime;
        }
    }
}
