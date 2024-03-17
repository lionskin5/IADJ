using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayTraceScreen : MonoBehaviour
{
    private bool firstTime = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Returns a ray going from camera through a screen point.
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        // Other: .Linecast() .BoxCast() .SphereCast() .CapsuleCast()
        if (Physics.Raycast(ray , out hit))
            draw (ray, hit); // Dibujar los rayos.
    }

    void draw(Ray ray, RaycastHit hit)
    {
        // The hit object is not the plane
        string str = hit.transform.gameObject.name;
        if (!(str.Equals("Plane") || str.Equals("Quad")))
        {
            Debug.DrawLine(ray.origin, hit.point, Color.red) ;
            Debug.DrawLine(hit.point, hit.point + 20*hit.normal, Color.blue);
        }
        // we will change the color, if possible
        changeColor(hit);
    }

    private GameObject firstThing = null;
    private GameObject secondThing = null;

    // GameObject’s mesh renderer to access the GameObject’s material and color
    MeshRenderer m_Renderer = null;
    //The original color of the GameObject
    Color m_OriginalColor = Color.green;

    void changeColor(RaycastHit hit)
    {
        string str = hit.transform.gameObject.name;
        if (firstTime && !(str.Equals("Plane") || str.Equals("Quad")))
        {
            firstThing = hit.transform.gameObject;
            m_Renderer = firstThing.GetComponent<MeshRenderer>();
            m_OriginalColor = m_Renderer.material.color;
            m_Renderer.material.color = Color.gray;
            firstTime = false;
            return;
        }

        if ( firstThing == null ) return;
        
        secondThing = hit.transform.gameObject;
        if (firstThing == secondThing) return;
        
        m_Renderer.material.color = m_OriginalColor;
        
        firstTime = true;
    }

}
