using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveGame : MonoBehaviour
{
    public GameObject Poop;
    static public int IsSaved = 0;
    public void SavingGame()
    {
        IsSaved = 1;
        PlayerPrefs.SetInt("IsSaved", IsSaved);
        PlayerPrefs.SetInt("BiggerValue", Upgrades.BiggerValue);
        PlayerPrefs.SetInt("FasterValue", Upgrades.FasterValue);
        PlayerPrefs.SetInt("AutoValue", Upgrades.AutoValue);
        PlayerPrefs.SetInt("FasterAutoValue", Upgrades.FasterAutoValue);
        PlayerPrefs.SetInt("PoopValue", ClickForPoint.PoopValue);
        PlayerPrefs.SetInt("CashCount", ClickForPoint.CashCount);
        PlayerPrefs.SetFloat("Timer", PurchesLogs.Timer);
        PlayerPrefs.SetInt("AutoPoopIncrease", PurchesLogs.AutoPoopIncrease);
        PlayerPrefs.SetFloat("Scalex", Poop.GetComponent<Transform>().localScale.x);
        PlayerPrefs.SetFloat("Scaley", Poop.GetComponent<Transform>().localScale.y);
        PlayerPrefs.SetFloat("Gravity", Poop.GetComponent<Rigidbody2D>().gravityScale);
        Debug.Log("Saved");
    }
}
