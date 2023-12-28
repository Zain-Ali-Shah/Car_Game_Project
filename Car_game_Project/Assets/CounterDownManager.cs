using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using Assets.ARCADE - FREE Racing Car.Prefabs (Meshes Only).Free Racing Car;

public class CounterDownManager : MonoBehaviour
{
    public GameObject CounterLabel;
    public GameObject Car;
    public GameObject AICar;
    public GameObject LapTimer;
    void Start()
    {
        StartCoroutine(CountDown());
    }
    IEnumerator CountDown()
    {
        yield return new WaitForSeconds(0.03f);
        CounterLabel.GetComponent<Text>().text = "3";
        CounterLabel.SetActive(true);
        yield return new WaitForSeconds(1);
        CounterLabel.SetActive(false);
        CounterLabel.GetComponent<Text>().text = "2";
        CounterLabel.SetActive(true);
        yield return new WaitForSeconds(1);
        CounterLabel.SetActive(false);
        CounterLabel.GetComponent<Text>().text = "1";
        CounterLabel.SetActive(true);
        yield return new WaitForSeconds(1);
        CounterLabel.SetActive(false);
        Car.GetComponent<Car_Accelerate>().enabled = true;
        AICar.GetComponent<AICarController>().enabled = true;
        LapTimer.GetComponent<LapTimerDown>().enabled = true;

    }
}
