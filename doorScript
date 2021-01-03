using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorScript : MonoBehaviour
{
    public GameObject doorOpen;
    public int emptyLightsLeft;

    private void Update()
    {
        if (emptyLightsLeft <= 0) {
            Instantiate(doorOpen, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
