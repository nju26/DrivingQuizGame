using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestTimeMaaa : MonoBehaviour
{
    public GameObject FinishLine;
    public GameObject MinDisplay;
    public GameObject SecDisplay;
    public GameObject MillDiaplay;

    public GameObject BestTimeBox;



    void OnTriggerEnter()
    {
        MinDisplay.GetComponent<Text>().text = string.Format("{0:D2}:", TimeManagerrr.MinCount);
        SecDisplay.GetComponent<Text>().text = string.Format("{0:D2}.", TimeManagerrr.SecCount);
        MillDiaplay.GetComponent<Text>().text = TimeManagerrr.MillCount.ToString("F0");

        TimeManagerrr.MinCount = 0;
        TimeManagerrr.SecCount = 0;
        TimeManagerrr.MillCount = 0;

        FinishLine.SetActive(false);
    }
    
}
