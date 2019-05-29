using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class StoneBrick : Brick
{
	public StoneBrick()
	{
		
		this.HP = 100;
		this.Name = "Stone";
		this.Mass = 10;
		this.Friction = 5.5f;
		this.Price = 25;
		this.Dmg = 30;
		
	}

	void Start()
	{
		Debug.Log("HP: " + this.HP);
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "Ball")
		{
			this.HP = (int)(this.HP - (col.collider.GetComponent<Rigidbody2D>().velocity.magnitude * col.collider.GetComponent<Rigidbody2D>().mass));
			if(this.HP <= 0)
			{
				Debug.Log("destroj");
				Destroy(this.gameObject);			
			}
			Debug.Log(this.HP);
		}
	}
}