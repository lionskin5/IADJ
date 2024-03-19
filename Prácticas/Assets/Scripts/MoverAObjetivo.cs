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
        // Mirar en la dirección del vector calculado.
       // transform.LookAt(transform.position + newTarget);
        // Avanzar de acuerdo a la velocidad establecida
        transform.position = newTarget;
    }
}
