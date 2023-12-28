using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICarController : MonoBehaviour
{
    public GameObject tracker; // Reference to the tracker object
    public float acceleration = 70f; // Increased acceleration factor for faster speed
    public float turnSpeed = 3f; // Turning speed of the AI car
    public float arrivalThreshold = 0.5f; // Distance threshold to consider the tracker point as reached

    void Update()
    {
        // Check if the tracker reference is set
        if (tracker == null)
        {
            Debug.LogError("Tracker reference not set for AICarController!");
            return;
        }

        // Calculate the direction to the tracker
        Vector3 directionToTracker = tracker.transform.position - transform.position;
        directionToTracker.y = 0f; // Ensure no vertical movement is considered

        // Rotate towards the tracker
        Quaternion targetRotation = Quaternion.LookRotation(directionToTracker);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, turnSpeed * Time.deltaTime);

        // Move forward
        transform.Translate(Vector3.forward * acceleration * Time.deltaTime);
    }
}
