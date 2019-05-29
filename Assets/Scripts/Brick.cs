using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
	[SerializeField]
	protected int HP;

	protected string Name { get; set; }
	protected int Mass { get; set; }
	protected float Friction { get; set; }
	protected int Price { get; set; }
	protected int Dmg { get; set; }

    float distance = 10f;

    void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        transform.position = objPosition;
    }  
}

