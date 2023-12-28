using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICarTracking : MonoBehaviour
{
    public GameObject point1;
    public GameObject point2;
    public GameObject point3;
    public GameObject point4;
    public GameObject point5;
    public GameObject point6;
    public GameObject point7;
    public GameObject point8;
    public GameObject Tracker;
    public int count;
    void Update()
    {
        if (count == 0)
        {
            Tracker.transform.position = point1.transform.position;
        }
        if (count == 1)
        {
            Tracker.transform.position = point2.transform.position;
        }
        if (count == 2)
        {
            Tracker.transform.position = point3.transform.position;
        }
        if (count == 3)
        {
            Tracker.transform.position = point4.transform.position;
        }
        if (count == 4)
        {
            Tracker.transform.position = point5.transform.position;
        }
        if (count == 5)
        {
            Tracker.transform.position = point6.transform.position;
        }
        if (count == 6)
        {
            Tracker.transform.position = point7.transform.position;
        }
        if (count == 7)
        {
            Tracker.transform.position = point8.transform.position;
        }
    }
    IEnumerator OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag == "AICar")
        {
            this.GetComponent<BoxCollider>().enabled = false;
            if (count == 8)
            {
                count = 0;
            }
            else
            {
                count = count + 1;
            }
            yield return new WaitForSeconds(0.02f);
            this.GetComponent<BoxCollider>().enabled = true;
        }
    }
}
