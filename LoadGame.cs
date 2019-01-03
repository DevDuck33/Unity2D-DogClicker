using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour
{
    public GameObject Poop;
    public GameObject RealLoadButton;
    public GameObject FakeLoadButton;

    void Start()
    {
        SaveGame.IsSaved = PlayerPrefs.GetInt("IsSaved");
        if (SaveGame.IsSaved == 1)
        {
                FakeLoadButton.SetActive(false);
                RealLoadButton.SetActive(true);
        }
        else
        {
                FakeLoadButton.SetActive(true);
                RealLoadButton.SetActive(false);
        }
    }

    public void LoadingGame()
    {
        Upgrades.BiggerValue = PlayerPrefs.GetInt("BiggerValue");
        Upgrades.FasterValue = PlayerPrefs.GetInt("FasterValue");
        Upgrades.AutoValue = PlayerPrefs.GetInt("AutoValue");
        Upgrades.FasterAutoValue = PlayerPrefs.GetInt("FasterAutoValue");
        ClickForPoint.PoopValue = PlayerPrefs.GetInt("PoopValue");
        ClickForPoint.CashCount = PlayerPrefs.GetInt("CashCount");
        PurchesLogs.Timer = PlayerPrefs.GetFloat("Timer");
        PurchesLogs.AutoPoopIncrease = PlayerPrefs.GetInt("AutoPoopIncrease");
        Poop.GetComponent<Transform>().localScale = new Vector3(PlayerPrefs.GetFloat("Scalex"), PlayerPrefs.GetFloat("Scaley"), 0f);
        Poop.GetComponent<Rigidbody2D>().gravityScale = PlayerPrefs.GetFloat("Gravity");
        SceneManager.LoadScene(1);
    }

}
