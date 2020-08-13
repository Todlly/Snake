using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class HeadMoving : MonoBehaviour
{
    [SerializeField]
    private Camera mainCamera;
    [SerializeField]
    private Rigidbody snakeHead;
    [SerializeField]
    public float speed;

    private Vector3 camOffset;
    // Start is called before the first frame update


    void Start()
    {
        snakeHead = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (mainCamera == null)
        {
            mainCamera = Camera.main;
            camOffset = mainCamera.transform.position - transform.position;
        }

        mainCamera.transform.position = transform.position + camOffset;
    }
    void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        snakeHead.transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            Debug.Log("Pressed left " + snakeHead.name);
            snakeHead.transform.Rotate(0, -90, 0);
        }
        else if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            snakeHead.transform.Rotate(0, 90, 0);
        }
    }
}
