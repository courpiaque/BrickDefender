using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
	private Rigidbody2D _ball;

    public void Fire()
    {
        System.Random rnd = new System.Random();

        float x = (float)(1 - (rnd.NextDouble() * 10 + 5));
        float y = (float)rnd.NextDouble() * 10;

        _ball = GetComponent<Rigidbody2D>();
        _ball.position = new Vector3(10, 2, 6);
        _ball.velocity = new Vector3(x, y, 0);
    }
}
