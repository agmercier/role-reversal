using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreenScript : MonoBehaviour
{
    public GameObject panel;
    public GameObject creditPanel;
    public GameObject controlPanel;

    private void Start()
    {
        controlPanel.SetActive(false);
        creditPanel.SetActive(false);
        panel.SetActive(true);
    }

    public void goStart()
    {
        SceneManager.LoadScene(0);
    }

     public void goControl()
    {
        controlPanel.SetActive(true);
        panel.SetActive(true);
        creditPanel.SetActive(false);
    }

    public void goCredit()
    {
        controlPanel.SetActive(false);
        panel.SetActive(false);
        creditPanel.SetActive(true);
    }

    public void goEnd()
    {
        controlPanel.SetActive(false);
        creditPanel.SetActive(false);
        panel.SetActive(true);
    }

    public void exitGame()
    {
        Debug.Log("exitgame");
        Application.Quit();
    }
}