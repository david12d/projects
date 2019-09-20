using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rolling : MonoBehaviour
{
    public int rollingSpeed;
    public Rigidbody rb;

    private void FixedUpdate()
    {
        rb.AddForce(0, 0, -rollingSpeed * Time.deltaTime);
    }
}
