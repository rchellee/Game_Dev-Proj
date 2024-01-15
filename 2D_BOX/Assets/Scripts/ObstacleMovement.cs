using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public float speed;
    public GameObject ways;
    private Transform[] wayPoints;
    private int pointIndex;
    private int direction = 1;

    private void Awake()
    {
        wayPoints = new Transform[ways.transform.childCount];
        for (int i = 0; i < ways.transform.childCount; i++)
        {
            wayPoints[i] = ways.transform.GetChild(i);
        }
    }

    private void Start()
    {
        pointIndex = 0;
        transform.position = wayPoints[pointIndex].position;
    }

    private void Update()
    {
        if (wayPoints.Length == 0)
            return;

        var step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, wayPoints[pointIndex].position, step);

        if (transform.position == wayPoints[pointIndex].position)
        {
            NextPoint();
        }
    }

    private void NextPoint()
    {
        pointIndex += direction;

        if (pointIndex >= wayPoints.Length || pointIndex < 0)
        {
            direction *= -1;
            pointIndex += direction;
        }
    }
}