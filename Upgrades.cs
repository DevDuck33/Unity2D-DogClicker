using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Upgrades : MonoBehaviour
{

    public GameObject FakeBiggerButton;
    public GameObject FakeBiggerText;
    public GameObject RealBiggerButton;
    public GameObject RealBiggerText;
    public int CurrentCash;
    public static int BiggerValue = 20;

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

    }
}
