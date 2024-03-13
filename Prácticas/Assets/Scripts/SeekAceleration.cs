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

    // Dibuja el gizmo de la velocidad y de la orientación
    private void OnDrawGizmos()
    {
        Vector3 from = transform.position; // Origen de la línea
        Vector3 to = transform.position + velocity; // Destino de la línea
        Vector3 elevation = new Vector3(0, 1, 0); // Elevación para no tocar el suelo

        from = from + elevation;
        to = to + elevation;

        Debug.Log("Velocidad: " + velocity);
        Debug.Log("From: " + from);
        Debug.Log("To: " + to);

        Gizmos.color = Color.yellow;   // Mirando en la dirección de la velocidad.
        Gizmos.DrawLine(from, to);

        Gizmos.color = Color.red;   // Mirando en la dirección de la orientación.
        Vector3 direction = transform.TransformDirection(Vector3.forward) * 5;
        Debug.Log("Direction: " + direction);
        Gizmos.DrawRay(from, direction);

    }

}
