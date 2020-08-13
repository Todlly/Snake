using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SegmentsMoving : MonoBehaviour
{
    private List<Vector3> turns = new List<Vector3>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddTurn(Vector3 turningPos)
    {
        turns.Add(turningPos);
    }
}
