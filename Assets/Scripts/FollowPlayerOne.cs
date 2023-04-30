using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerOne : MonoBehaviour
{
    public Transform player;	// A variable that stores a reference to our Player
	public Vector3 offset;	
   
    	// A variable that stores a reference to our Player
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
         transform.position = player.position + offset;
    }
}
