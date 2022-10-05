using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoyScript : MonoBehaviour
{
    public int RoyHealth;
    public float fallSpeed;
    public float timeDeath;

    public float attackTime;
    private float duration;
    public float SinkPos;

    public Animator anim;

    void Start()
    {
        RoyHealth = 3;
        duration = attackTime;
    }

    void FixedUpdate()
    {
        if (RoyHealth <= 0)
        {
            // Idle Mode
            // Instantiate rumbling death effect
            anim.SetBool("isAttacking", false);

            transform.Translate(Vector3.down * fallSpeed * Time.deltaTime, Space.World);

            if (transform.position.y <= SinkPos)
            {
                Destroy(gameObject);
            }
        }

        else
        {
            attack();
        }
    }

    public void attack()
    {
        if(duration <= 0)
        {
            //attack Mode
            anim.SetBool("isAttacking", true);
            duration = attackTime;
        }

        else
        {
            duration -= Time.deltaTime;
        }
    }
}
