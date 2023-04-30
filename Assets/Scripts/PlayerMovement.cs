using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject[] waypoints;
    public int current;
    public float speed;
    float WPradius = 1;

    public Canvas elevatorPanel; // Reference to the canvas panel to show when elevator stops

    void Start()
    {
       elevatorPanel.gameObject.SetActive(true);
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, waypoints[current].transform.position, Time.deltaTime * speed);
        if (Vector3.Distance(transform.position, waypoints[current].transform.position) < WPradius)
        {
           elevatorPanel.gameObject.SetActive(true);
        }
        else
        {
            elevatorPanel.gameObject.SetActive(false);
        }
    }

    public void SetCurrentWaypoint(int waypointIndex)
    {
        current = waypointIndex;
    }
}
