using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapTimerDown : MonoBehaviour
{
    public GameObject milliLabel;
    public GameObject secondLabel;
    public GameObject minLabel;
    public static int min;
    public static int sec;
    public static float milli;
    void Update()
    {
        milli = milli + Time.deltaTime * 10;
        milliLabel.GetComponent<Text>().text = "" + milli.ToString("F0");
        if (milli > 9)
        {
            sec = sec + 1;
            milli = 0;
        }
        if (sec>=0 && sec < 10)
        {
            secondLabel.GetComponent<Text>().text = "0" + sec.ToString() + ".";
        }
        else if (sec > 10 && sec <= 59)
        {
            secondLabel.GetComponent<Text>().text = "" + sec.ToString() + ".";
        }
        else if (sec == 60)
        {
            sec = 0;
            min = min + 1;
        }
        if (min >= 0 && min < 10)
        {
            minLabel.GetComponent<Text>().text = "0" + min.ToString() + ":";
        }
        else if (min > 10 && min <= 59)
        {
            minLabel.GetComponent<Text>().text = "" + min.ToString() + ":";
        }
    }
}
