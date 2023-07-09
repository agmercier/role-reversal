using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScreenScript : MonoBehaviour
{
    public GameObject objpanel1;
    public GameObject creditPanel1;
    public GameObject creditPanel2;
    public GameObject creditPanel3;
    public GameObject controlPanel;

    private void Start()
    {
        controlPanel.SetActive(false);
        creditPanel1.SetActive(false);
        objpanel1.SetActive(true);
        creditPanel2.SetActive(false);
        creditPanel3.SetActive(false);
    }

    public void goStart()
    {
        SceneManager.LoadScene(0);
    }

     public void goControl()
    {
        controlPanel.SetActive(true);
        objpanel1.SetActive(false);
        creditPanel1.SetActive(false);
        creditPanel2.SetActive(false);
        creditPanel3.SetActive(false);
    }

    public void goCredit1()
    {
        controlPanel.SetActive(false);
        objpanel1.SetActive(false);
        creditPanel1.SetActive(true);
        creditPanel2.SetActive(false);
        creditPanel3.SetActive(false);
    }

    public void goCredit2()
    {
        controlPanel.SetActive(false);
        objpanel1.SetActive(false);
        creditPanel1.SetActive(false);
        creditPanel2.SetActive(true);
        creditPanel3.SetActive(false);
    }

    public void goCredit3()
    {
        controlPanel.SetActive(false);
        objpanel1.SetActive(false);
        creditPanel1.SetActive(false);
        creditPanel2.SetActive(false);
        creditPanel3.SetActive(true);
    }

    public void exitGame()
    {
        Debug.Log("exitgame");
        Application.Quit();
    }
}