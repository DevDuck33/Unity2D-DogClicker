using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchesLogs : MonoBehaviour
{
    public static float BiggerCost;
    public GameObject Poop;

    public void BiggerPoop()
    {
        ClickForPoint.CashCount -= Upgrades.BiggerValue;
        BiggerCost = (float)Upgrades.BiggerValue * 1.4f;
        Upgrades.BiggerValue = (int)Mathf.Round(BiggerCost);
        ClickForPoint.PoopValue += 1;
        Debug.Log(ClickForPoint.PoopValue);
        Debug.Log(Upgrades.BiggerValue);
        Poop.GetComponent<Transform>().localScale += new Vector3(0.1f, 0.1f, 0f);
        Debug.Log(Poop.GetComponent<Transform>().localScale);
    }
}
