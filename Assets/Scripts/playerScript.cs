using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    public GameObject effect;

    public GameObject deadBody;
    public GameObject DeadoptionScript;

    public Rigidbody2D rb;
    public float speed;
    private Vector2 moveInput;
    private bool facingRight;

    private float duration;
    public float startTime;


    private void Start()
    {
       facingRight = true;
      
    }

    void Update()
    {

        moveInput = new Vector2(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"));

        if(facingRight == true && moveInput.x == -1)
        {
            flip();
        }

        if (facingRight == false && moveInput.x == 1)
        {
            flip();
        }

        effector();
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveInput*speed*Time.deltaTime);
    }

    private void flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }

    private void effector()
    {
        if (duration <= 0)
        {
            Instantiate(effect, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
            duration = startTime;
        }

        else
        {
            duration -= Time.deltaTime;
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Obstacle"))
        {
            Instantiate(deadBody, new Vector3(transform.position.x, transform.position.y, transform.position.y), Quaternion.identity);
            Instantiate(DeadoptionScript, new Vector3(0f, 0f, 0f), Quaternion.identity);
            Destroy(gameObject);
        }
    }
}


