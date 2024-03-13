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

        Gizmos.color = Color.blue;
        // El From es normalmente donde se encuentra el personaje. De hecho, es el mismo para velocidad y orientación
 //       Vector3 from = transform.position;

 //       Vector3 newDirection = target.position - transform.position;

  //      Vector3 velocityGiz = newDirection * maxAceleration * 2f;

   //     Vector3 velTo = transform.localPosition + velocityGiz;
   //     Vector3 orienTo = newDirection;
        

        Vector3 velActual = new Vector3(-5, 0, 3);
        Debug.Log("Velocidad: " + velActual);

        // Elevación para no tocar el suelo
        Vector3 elevation = new Vector3 (0 , 1 , 0) ;
        Vector3 from = transform.position + elevation;
        Vector3 to = from + velActual + elevation;
       // Vector3 orienTo = orienTo + elevation;
        Debug.Log("From: " + from);
        Gizmos.DrawLine (from , to);

        // Gizmos.color = Color.black;
        // Gizmos.DrawLine (from , orienTo);

    }

}
