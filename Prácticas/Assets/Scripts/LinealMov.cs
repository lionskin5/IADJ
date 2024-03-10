using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinealMov : MonoBehaviour
{
    public float velocity = 4; // Máxima velocidad

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * velocity * Time.deltaTime;
    }
}
