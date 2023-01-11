using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaipointFollower : MonoBehaviour
{
    [SerializeField] GameObject[] waypoints;
    int currentWaypointINdex = 0;

    [SerializeField] float speed = 3f;

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, waypoints[currentWaypointINdex].transform.position) < .1f)
        {
            currentWaypointINdex++;
            if(currentWaypointINdex >= waypoints.Length)
            {
                currentWaypointINdex = 0;
            }
        }
        
        transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypointINdex].transform.position, speed * Time.deltaTime);

    }
}
