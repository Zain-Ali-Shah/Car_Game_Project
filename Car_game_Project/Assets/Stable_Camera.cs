using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float X;
    public float Y;
    public float Z;
    public GameObject Car;
    // Start is called before the first frame update
    //void Start()
    //{
        
    //}

    // Update is called once per frame
    void Update()
    {
        X = Car.transform.eulerAngles.x;
        Y = Car.transform.eulerAngles.y;
        Z = Car.transform.eulerAngles.z;
        transform.eulerAngles = new Vector3(X - X, Y, Z - Z);
    }
}
