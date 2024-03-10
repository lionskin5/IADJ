using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wander : MonoBehaviour
{

    public float velocity = 4; // Máxima velocidad
    public float maxAngle = 360; // Una circunferencia
    private float angle = 0f; // Angulo de orientación actual.
    private float newAngle = 0f; // Nuevo ángulo (será aleatorio)

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("NewDirection"); // Inicia la corrutina 
    }

    // Update is called once per frame
    void Update()
    {
        angle = Mathf.LerpAngle(angle, newAngle, Time.deltaTime);
        transform.eulerAngles = new Vector3(0, angle, 0);
        transform.position += transform.forward * velocity * Time.deltaTime;
    }

    IEnumerator NewDirection ()
    {
        while(true)
        {
            // yield, cede el control a Unity. Rotomará el control pasado 0.25f
            yield return new WaitForSeconds(0.25f); // Cambiar orientación
            newAngle = (Random.value - Random.value ) * maxAngle;
        }
    }



}
