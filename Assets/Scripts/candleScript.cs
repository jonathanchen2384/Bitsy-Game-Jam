using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class candleScript : MonoBehaviour
{
    public GameObject lightUp;
    public GameObject closedDoor;

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")||collision.CompareTag("Flame")) {

            closedDoor.GetComponent<doorScript>().emptyLightsLeft -= 1;
            Instantiate(lightUp, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
