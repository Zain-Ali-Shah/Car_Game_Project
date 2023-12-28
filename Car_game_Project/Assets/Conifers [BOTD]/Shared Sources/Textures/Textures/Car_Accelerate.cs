using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_Accelerate: MonoBehaviour
{
    public float speed = 10f;
    public float acceleration = 15f;
    public static float maxSpeed = 80f;
    public float turnSpeed = 15f;
    public float raycastDistance = 10f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            speed += acceleration * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            speed -= acceleration * Time.deltaTime;
        }
        else
        {
            // Slow down when the button is not pressed
            speed -= acceleration * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
        }
        // Turn the car right when the "Turn Right" button (right arrow key) is pressed
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
        }
        if (Physics.Raycast(transform.position, Vector3.down, raycastDistance))
        {
            // Adjust the car's position on the y-axis to keep it on the ground
            float targetHeight = transform.position.y; // You can set this to the desired height from the ground

            // Smoothly interpolate the current height to the target height
            float currentHeight = Mathf.Lerp(transform.position.y, targetHeight, Time.deltaTime * 5f);

            // Update the car's position
            transform.position = new Vector3(transform.position.x, currentHeight, transform.position.z);
        }

        // Clamp the speed to be within the specified range
        speed = Mathf.Clamp(speed, 0f, maxSpeed);

        // Move the car forward based on the current speed
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
