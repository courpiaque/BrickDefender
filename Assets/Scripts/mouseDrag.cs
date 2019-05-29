using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseDrag : MonoBehaviour
{
    float distance = 10f;

    void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
