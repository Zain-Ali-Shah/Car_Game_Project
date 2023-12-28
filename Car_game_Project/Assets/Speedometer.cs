using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Speedometer : MonoBehaviour
{
    public GameObject speedLabel;
    public Rigidbody Car;
    public int maxSpeed = 260;
    public float speed;
    void Update()
    {
        
        speed = Car.velocity.magnitude * 3.6f;
        speedLabel.GetComponent<Text>().text = (int)speed + " km/h";
        //Debug.Log("Speed: " + speed);
    }
}
