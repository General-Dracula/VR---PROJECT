using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingTarget : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    public float speed;
    private Transform target;

    private void Start() {
        target = pointA;
    }

    void Update()
    {
        float step = speed * Time.deltaTime;

        if (Vector3.Distance(transform.position, target.position) <= 1f)
        {
            ChangeTarget();
        }

        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    }
    
    private void ChangeTarget()
    {
        if (target == pointA)
        {
            target = pointB;
        }
        else 
        {
            target = pointA;
        }
    }
}
