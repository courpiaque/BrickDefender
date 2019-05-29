using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    protected GameObject[] bricks;
    protected GameMode gameMode;

    [SerializeField] private GameObject brickPrefab;

    private void Awake()
    {
        gameMode = new GameMode
        {
            Flag = false
        };
    }

    public void Building()
    {
        if (gameMode.Flag == false)
        {
            GameObject brick = Instantiate(brickPrefab);
            brick.transform.position = new Vector3(6, 1, 0);
        }
    }

    public void StartGame()
    {
        bricks = GameObject.FindGameObjectsWithTag("Wall");

        for (int i = 0; i < bricks.Length; i++)
        {
            bricks[i].GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        }

        gameMode.Flag = true;
    }

    public void Rotate()
    {
        if (gameMode.Flag == false)
        {
            bricks = GameObject.FindGameObjectsWithTag("Wall");
            bricks[bricks.Length - 1].transform.Rotate(0, 0, 90);
        }       
    }
}
