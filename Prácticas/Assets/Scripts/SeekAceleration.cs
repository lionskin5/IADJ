using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seek1 : MonoBehaviour
{
    public Transform target; // Comenta adecuadamente.
    public float maxAceleration = 2;
    public float maxVelocity = 4;
    private Vector3 velocity = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newDirection = target.position - transform.position;

        transform.LookAt(transform.position + newDirection);

        velocity += newDirection * maxAceleration * Time.deltaTime;

        if (velocity.magnitude > maxVelocity)
            velocity = velocity.normalized * maxVelocity;

        transform.position += velocity * Time.deltaTime;
    }
}
