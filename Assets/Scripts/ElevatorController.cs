using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorController : MonoBehaviour
{
    public PlayerMovement playerMovementScript;
    public PlayerMovementTwo playerMovementTwoScript;

    void Start()
    {
        playerMovementScript = GameObject.FindObjectOfType<PlayerMovement>();
        playerMovementTwoScript = GameObject.FindObjectOfType<PlayerMovementTwo>();
    }

    public void FirstLift(int floor)
    {
        playerMovementScript.SetCurrentWaypoint(floor);
    }

     public void SecondLift(int floor)
    {
        // Get a reference to the second Movement script
       

        // Call the SetCurrentWaypoint function of the second Movement script to change the current waypoint
    playerMovementTwoScript.SetCurrentWaypoint(floor);
    
    }

    
}

