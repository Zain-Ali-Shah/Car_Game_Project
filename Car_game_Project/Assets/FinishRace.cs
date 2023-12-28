using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishRace : MonoBehaviour
{
    public GameObject Car;
    public GameObject FinishCamera;
    public GameObject NormalCamera;
    public GameObject FinishPoint;
    void onTriggerEnter()
    {
        this.GetComponent<BoxCollider>().enabled = false;
        Car.SetActive(false);
        Car_Accelerate.maxSpeed = 0.0f;
        Car.GetComponent<Car_Accelerate>().enabled = false;
        Car.SetActive(true);
        FinishCamera.SetActive(true);
        NormalCamera.SetActive(false);
    }
}
