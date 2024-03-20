using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverAObjetivo : MonoBehaviour
{

    public float velocity = 2;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void NewTarget(Vector3 newTarget) {

        // Diferencia de posiciones entre el objetivo y este objeto.
        Vector3 newDirection = newTarget - transform.position;

        Debug.Log("newTarget: " + newTarget); 
       // Debug.Log("transform.position: " + transform.position);
        Debug.Log("newTarget.magnitude: " + newTarget.magnitude);
        Debug.Log("newDirection.magnitude: " + newDirection.magnitude);
        Debug.Log("Resta1: " + Mathf.Abs(newTarget.magnitude - newDirection.magnitude));

        int i = 0;

        while(Mathf.Abs(newDirection.magnitude) > 5 ) {

        //while(i < 3) {
          //  Debug.Log("Resta: " + Mathf.Abs(newTarget.magnitude - newDirection.magnitude));
            // Avanzar de acuerdo a la velocidad establecida
            transform.position += newDirection * velocity * Time.deltaTime;
          //  Debug.Log("Nueva Posición Bucle: " + transform.position);
            newDirection = newTarget - transform.position;
          //  Debug.Log("Nueva Dirección Bucle: " + newDirection);
            Debug.Log("Nueva Dirección Magnitud: " + newDirection.magnitude);
            i++;
            Debug.Log("I: " + i);
        }



        //Debug.Log("transform.position: " + transform.position);
        //Debug.Log("newDirection: " + newDirection); 
        // Mirar en la dirección del vector calculado.
       // transform.LookAt(transform.position + newTarget);
        // Avanzar de acuerdo a la velocidad establecida
        //transform.position += newDirection;
    }
}
