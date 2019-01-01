using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitTheGame : MonoBehaviour
{
    public GameObject ExitPanel;
    public void OpenExit()
    {
        ExitPanel.SetActive(true);
    }

    public void CloseExit()
    {
        ExitPanel.SetActive(false);
    }

    public void LeaveTheGame()
    {
        Application.Quit();
    }
}
