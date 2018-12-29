using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCloseShop : MonoBehaviour
{
    public GameObject ShopPanel;
    public void OpenedShop()
    {
        ShopPanel.SetActive(true);
    }

    public void ClosedShop()
    {
        ShopPanel.SetActive(false);
    }
}
