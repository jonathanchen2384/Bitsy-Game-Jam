using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinningEffect : MonoBehaviour
{
    public float spinSpeed;

    private void Update()
    {
        transform.Rotate(0f, 0f, spinSpeed, Space.World);
    }
}
