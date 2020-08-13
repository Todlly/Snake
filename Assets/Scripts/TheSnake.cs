using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheSnake : MonoBehaviour
{
    [SerializeField]
    private GameObject snakeHead;
    private float speed;

    [SerializeField]
    private float Speed
    {
        get => speed;
        set
        {
            speed = value;
            snakeHead.GetComponent<HeadMoving>().speed = value;
            Debug.Log(snakeHead.GetComponent<HeadMoving>().speed);
        }
    }

    void Start()
    {
        Speed = 5f;
        GameObject.Instantiate(snakeHead, new Vector3(0, snakeHead.transform.localScale.y / 2, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
