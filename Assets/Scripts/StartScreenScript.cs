using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreenScript : MonoBehaviour
{
    public GameObject panel;
    public GameObject creditPanel1;
    public GameObject creditPanel2;
    public GameObject creditPanel3;
    public GameObject creditPanel4;
    public GameObject controlPanel;

    private void Start()
    {
        controlPanel.SetActive(false);
        creditPanel1.SetActive(false);
        panel.SetActive(true);
        creditPanel2.SetActive(false);
        creditPanel3.SetActive(false);
        creditPanel4.SetActive(false);
    }

    public void goStart()
    {
        SceneManager.LoadScene(0);
    }

     public void goControl()
    {
        controlPanel.SetActive(true);
        panel.SetActive(true);
        creditPanel1.SetActive(false);
        creditPanel2.SetActive(false);
        creditPanel3.SetActive(false);
        creditPanel4.SetActive(false);
    }

    public void goCredit1()
    {
        controlPanel.SetActive(false);
        panel.SetActive(true);
        creditPanel1.SetActive(true);
        creditPanel2.SetActive(false);
        creditPanel3.SetActive(false);
        creditPanel4.SetActive(false);
    }

    public void goCredit2()
    {
        controlPanel.SetActive(false);
        panel.SetActive(true);
        creditPanel1.SetActive(false);
        creditPanel2.SetActive(true);
        creditPanel3.SetActive(false);
        creditPanel4.SetActive(false);
    }

    public void goCredit3()
    {
        controlPanel.SetActive(false);
        panel.SetActive(true);
        creditPanel1.SetActive(false);
        creditPanel2.SetActive(false);
        creditPanel3.SetActive(true);
        creditPanel4.SetActive(false);
    }

    public void goCredit4()
    {
        controlPanel.SetActive(false);
        panel.SetActive(true);
        creditPanel1.SetActive(false);
        creditPanel2.SetActive(false);
        creditPanel3.SetActive(false);
        creditPanel4.SetActive(true);
    }

    public void goEnd()
    {
        controlPanel.SetActive(false);
        creditPanel1.SetActive(false);
        panel.SetActive(true);
        creditPanel2.SetActive(false);
        creditPanel3.SetActive(false);
        creditPanel4.SetActive(false);
    }

    public void exitGame()
    {
        Debug.Log("exitgame");
        Application.Quit();
    }
}