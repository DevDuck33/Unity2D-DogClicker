using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchesLogs : MonoBehaviour
{
    public static float BiggerCost;
    public static float FasterCost;
    public static float AutoCost;
    public GameObject Poop;
    public static int AutoPoopIncrease = 0;
    public GameObject AutoPoopObject;

    public void BiggerPoop()
    {
        ClickForPoint.CashCount -= Upgrades.BiggerValue;
        BiggerCost = (float)Upgrades.BiggerValue * 1.6f;
        Upgrades.BiggerValue = (int)Mathf.Round(BiggerCost);
        ClickForPoint.PoopValue += 1;
        Poop.GetComponent<Transform>().localScale += new Vector3(0.02f, 0.02f, 0f);
    }

    public void FasterPoop()
    {
        ClickForPoint.CashCount -= Upgrades.FasterValue;
        FasterCost = (float)Upgrades.FasterValue * 1.8f;
        Upgrades.FasterValue = (int)Mathf.Round(FasterCost);
        Poop.GetComponent<Rigidbody2D>().gravityScale += 0.2f;   
    }

    public void AutoPoop()
    {
        ClickForPoint.CashCount -= Upgrades.AutoValue;
        AutoPoopObject.SetActive(true);
        AutoPoopIncrease += 1;
        AutoCost = (float)Upgrades.AutoValue * 1.8f;
        Upgrades.AutoValue = (int)Mathf.Round(AutoCost);
    }
}
