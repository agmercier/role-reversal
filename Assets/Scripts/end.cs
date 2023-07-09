using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class end : MonoBehaviour
{
    public GameObject panel;
    public GameObject creditPanel1e;
    public GameObject creditPanel2e;
    public GameObject creditPanel3e;
    public GameObject creditPanel4e;


    private void Start()
    {
        creditPanel1e.SetActive(false);
        panel.SetActive(true);
        creditPanel2e.SetActive(false);
        creditPanel3e.SetActive(false);
        creditPanel4e.SetActive(false);
    }

    public void goStart()
    {
        SceneManager.LoadScene(0);
    }

    public void goCredit1()
    {
        panel.SetActive(true);
        creditPanel1e.SetActive(true);
        creditPanel2e.SetActive(false);
        creditPanel3e.SetActive(false);
        creditPanel4e.SetActive(false);
    }

    public void goCredit2()
    {
        panel.SetActive(true);
        creditPanel1e.SetActive(false);
        creditPanel2e.SetActive(true);
        creditPanel3e.SetActive(false);
        creditPanel4e.SetActive(false);
    }

    public void goCredit3()
    {
        panel.SetActive(true);
        creditPanel1e.SetActive(false);
        creditPanel2e.SetActive(false);
        creditPanel3e.SetActive(true);
        creditPanel4e.SetActive(false);
    }

    public void goCredit4()
    {
        panel.SetActive(true);
        creditPanel1e.SetActive(false);
        creditPanel2e.SetActive(false);
        creditPanel3e.SetActive(false);
        creditPanel4e.SetActive(true);
    }

    public void goEnd()
    {
        creditPanel1e.SetActive(false);
        panel.SetActive(true);
        creditPanel2e.SetActive(false);
        creditPanel3e.SetActive(false);
        creditPanel4e.SetActive(false);
    }

    public void exitGame()
    {
        Debug.Log("exitgame");
        Application.Quit();
    }
}