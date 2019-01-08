using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAutoPoop : MonoBehaviour
{
    public GameObject AutoPoopObject;
    void Update()
    {
        if (PurchesLogs.AutoPoopIncrease >= 1)
        {
            AutoPoopObject.SetActive(true);
        }
    }
}
