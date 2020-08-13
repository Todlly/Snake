using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Segment : MonoBehaviour
{
    private List<Vector3> turns = new List<Vector3>();

    private Rigidbody segment;

    void Start()
    {
        segment = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (turns.Count > 0)
        {
            segment.MovePosition(turns[0]);
        }
        else
        {
          //  segment.MovePosition
        }
    }

    public void AddTurn(Vector3 turnPos)
    {
        turns.Add(turnPos);
    }
}
