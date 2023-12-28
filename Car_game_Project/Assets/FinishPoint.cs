using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishPoint : MonoBehaviour
{
    public GameObject MinLabelBest;
    public GameObject SecLabelBest;
    public GameObject MilliLabelBest;
    public GameObject FPoint;
    public GameObject LapsCounterLabel;
    public int lapsCounter=0;
    public GameObject RaceFinish;
    private bool lapIncremented = false;
    private bool bestTimeUpdated = false;
    void OnTriggerEnter()
    {
        if (lapIncremented == false)
        {
            lapsCounter = lapsCounter + 1;
            lapIncremented = true;
            if (!bestTimeUpdated)
            {
                UpdateBestTimeLabels();
                bestTimeUpdated = true;
            }
        }
        if (lapsCounter >= 2)
        {
            RaceFinish.SetActive(true);
        }
        /*MilliLabelBest.GetComponent<Text>().text = "" + LapTimerDown.milli.ToString("F0");
        if (LapTimerDown.sec >= 0 && LapTimerDown.sec < 10)
        {
            SecLabelBest.GetComponent<Text>().text = "0" + LapTimerDown.sec.ToString() + ".";
        }
        else if (LapTimerDown.sec > 10 && LapTimerDown.sec <= 59)
        {
            SecLabelBest.GetComponent<Text>().text = "" + LapTimerDown.sec.ToString() + ".";
        }
        if (LapTimerDown.min >= 0 && LapTimerDown.min < 10)
        {
            MinLabelBest.GetComponent<Text>().text = "0" + LapTimerDown.min.ToString() + ":";
        }
        else if (LapTimerDown.min > 10 && LapTimerDown.min <= 59)
        {
            MinLabelBest.GetComponent<Text>().text = "" + LapTimerDown.min.ToString() + ":";
        }
        LapsCounterLabel.GetComponent<Text>().text = "" + lapsCounter;
        LapTimerDown.milli = 0;
        LapTimerDown.sec = 0;
        LapTimerDown.min = 0;*/
        StartCoroutine(ResetLapIncrement());
        //FPoint.SetActive(false);
    }
    void UpdateBestTimeLabels()
    {
        MilliLabelBest.GetComponent<Text>().text = "" + LapTimerDown.milli.ToString("F0");

        if (LapTimerDown.sec >= 0 && LapTimerDown.sec < 10)
        {
            SecLabelBest.GetComponent<Text>().text = "0" + LapTimerDown.sec.ToString() + ".";
        }
        else if (LapTimerDown.sec >= 10 && LapTimerDown.sec <= 59)
        {
            SecLabelBest.GetComponent<Text>().text = "" + LapTimerDown.sec.ToString() + ".";
        }

        if (LapTimerDown.min >= 0 && LapTimerDown.min < 10)
        {
            MinLabelBest.GetComponent<Text>().text = "0" + LapTimerDown.min.ToString() + ":";
        }
        else if (LapTimerDown.min >= 10 && LapTimerDown.min <= 59)
        {
            MinLabelBest.GetComponent<Text>().text = "" + LapTimerDown.min.ToString() + ":";
        }

        LapsCounterLabel.GetComponent<Text>().text = "" + lapsCounter;
    }
    IEnumerator ResetLapIncrement()
    {
        yield return new WaitForSeconds(3f); // Adjust the delay as needed
        lapIncremented = false;
        bestTimeUpdated = false;
    }
}
