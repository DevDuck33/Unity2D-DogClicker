using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Upgrades : MonoBehaviour
{
    public int CurrentCash;

    public GameObject FakeBiggerButton;
    public GameObject FakeBiggerText;
    public GameObject RealBiggerButton;
    public GameObject RealBiggerText;
    public static int BiggerValue = 20;

    public GameObject FakeFasterButton;
    public GameObject FakeFasterText;
    public GameObject RealFasterButton;
    public GameObject RealFasterText;
    public static int FasterValue = 50;

    void Update()
    {
        CurrentCash = ClickForPoint.CashCount;
        FakeBiggerText.GetComponent<Text>().text = "Buy BiggerPoop - " + BiggerValue + "$";
        RealBiggerText.GetComponent<Text>().text = "Buy BiggerPoop - " + BiggerValue + "$";
        if (CurrentCash >= BiggerValue)
        {
            FakeBiggerButton.SetActive(false);
            RealBiggerButton.SetActive(true);
        }
        else
        {
            FakeBiggerButton.SetActive(true);
            RealBiggerButton.SetActive(false);
        }

        FakeFasterText.GetComponent<Text>().text = "Buy FasterPoop - " + FasterValue + "$";
        RealFasterText.GetComponent<Text>().text = "Buy FasterPoop - " + FasterValue + "$";
        if (CurrentCash >= FasterValue)
        {
            FakeFasterButton.SetActive(false);
            RealFasterButton.SetActive(true);
        }
        else
        {
            FakeFasterButton.SetActive(true);
            RealFasterButton.SetActive(false);
        }
    }
}
