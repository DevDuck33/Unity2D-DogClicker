using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickForPoint : MonoBehaviour
{
    public GameObject ScoreText;
    public GameObject Dog;
    public GameObject Poop;
    public static int CashCount;
    public static int PoopValue = 1;
    public int InternalCash;
    public static bool CanPoop = true;
    public GameObject SpawnPoint;

    /*
    void Start()
    {
        Poop.GetComponent<Transform>().localScale = new Vector3(0.2f, 0.2f, 0f);
        Poop.GetComponent<Rigidbody2D>().gravityScale = 1;
    }
    */

    void Update()
    {
        InternalCash = CashCount;
        ScoreText.GetComponent<Text>().text = "$" + CashCount;
    }

    public void OnMouseDown()
    {
        if (CanPoop == true)
        {
            Dog.GetComponent<Animation>().Play("ClickDog");
            Instantiate(Poop);
            CashCount += PoopValue;
            CanPoop = false;
        }
    }

}
