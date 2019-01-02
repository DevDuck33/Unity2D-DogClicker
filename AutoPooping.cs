using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoPooping : MonoBehaviour
{
    public bool CreatingThePoop = false;
    public static float Timer = 2f;

    void Update()
    {
        if (CreatingThePoop == false)
        {
            CreatingThePoop = true;
            StartCoroutine(CreateThePoop());
        }
    }

    IEnumerator CreateThePoop()
    {
        ClickForPoint.CashCount += (ClickForPoint.PoopValue) * (PurchesLogs.AutoPoopIncrease);
        yield return new WaitForSeconds(Timer);
        CreatingThePoop = false;
    }
}
