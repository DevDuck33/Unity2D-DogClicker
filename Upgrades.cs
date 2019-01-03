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
    public static int FasterValue = 30;

    public GameObject FakeAutoButton;
    public GameObject FakeAutoText;
    public GameObject RealAutoButton;
    public GameObject RealAutoText;
    public static int AutoValue = 70;

    public GameObject FakeFasterAutoButton;
    public GameObject FakeFasterAutoText;
    public GameObject RealFasterAutoButton;
    public GameObject RealFasterAutoText;
    public static int FasterAutoValue = 150;

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

        FakeFasterText.GetComponent<Text>().text = "Buy FasterFalling - " + FasterValue + "$";
        RealFasterText.GetComponent<Text>().text = "Buy FasterFalling - " + FasterValue + "$";
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

        FakeAutoText.GetComponent<Text>().text = "Buy AutoPoop - " + AutoValue + "$";
        RealAutoText.GetComponent<Text>().text = "Buy AutoPoop - " + AutoValue + "$";
        if (CurrentCash >= AutoValue)
        {
            FakeAutoButton.SetActive(false);
            RealAutoButton.SetActive(true);
        }
        else
        {
            FakeAutoButton.SetActive(true);
            RealAutoButton.SetActive(false);
        }

        FakeFasterAutoText.GetComponent<Text>().text = "Buy FasterAutoPoop - " + FasterAutoValue + "$";
        RealFasterAutoText.GetComponent<Text>().text = "Buy FasterAutoPoop - " + FasterAutoValue + "$";
        if (CurrentCash >= FasterAutoValue)
        {
            FakeFasterAutoButton.SetActive(false);
            RealFasterAutoButton.SetActive(true);
        }
        else
        {
            FakeFasterAutoButton.SetActive(true);
            RealFasterAutoButton.SetActive(false);
        }

    }
}
