using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seek : MonoBehaviour
{

    public Transform target; // Referencia al Tranform de un objeto externo.
    public float velocity = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update ()
    {
        // Diferencia de posiciones entre el objetivo y este objeto.
        Vector3 newDirection = target.position - transform.position;
        // Mirar en la dirección del vector calculado.
        transform.LookAt(transform.position + newDirection);
        // Avanzar de acuerdo a la velocidad establecida
        transform.position += newDirection * velocity * Time.deltaTime;
    }

    private void OnDrawGizmos ()
    // El gizmo: una línea en la dirección del objetivo
    {
        // Origen de la línea
        Vector3 from = transform.position;
        // Destino de la línea
        Vector3 to = transform.localPosition + (target.position - transform.position) * velocity;
        // Elevación para no tocar el suelo
        Vector3 elevation = new Vector3 (0 , 1 , 0) ;
        from = from + elevation;
        to = to + elevation;
        Gizmos.DrawLine (from , to);
    }

}
