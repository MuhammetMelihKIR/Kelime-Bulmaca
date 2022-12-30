using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class butonController : MonoBehaviour
{
    public GameObject ilkekran;
    public GameObject anamemenüCanvas;
    public GameObject bölüm1;
    public GameObject bölün2;
    public GameObject bölüm3;
    public GameObject bölüm4;
    // Start is called before the first frame update
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void oynabölüm1()
    {
        anamemenüCanvas.SetActive(false);
        bölüm1.SetActive(true);
        bölün2.SetActive(false);
        bölüm3.SetActive(false);
        bölüm4.SetActive(false);

    }
    public void oynabölüm2()
    {
        anamemenüCanvas.SetActive(false);
        bölüm1.SetActive(false);
        bölün2.SetActive(true);
        bölüm3.SetActive(false);
        bölüm4.SetActive(false);


    }
    public void oynabölüm3()
    {
        anamemenüCanvas.SetActive(false);
        bölüm1.SetActive(false);
        bölün2.SetActive(false);
        bölüm3.SetActive(true);
        bölüm4.SetActive(false);

    }
    public void oynabölüm4()
    {
        anamemenüCanvas.SetActive(false);
        bölüm1.SetActive(false);
        bölün2.SetActive(false);
        bölüm3.SetActive(false);
        bölüm4.SetActive(true);
    }
    public void geributon()
    {
        ilkekran.SetActive(false);
        anamemenüCanvas.SetActive(true);
        bölüm1.SetActive(false);
        bölün2.SetActive(false);
        bölüm3.SetActive(false);
        bölüm4.SetActive(false);

    }
    public void startbuton()
    {
        ilkekran.SetActive(false);
        anamemenüCanvas.SetActive(true);
        bölüm1.SetActive(false);
        bölün2.SetActive(false);
        bölüm3.SetActive(false);
        bölüm4.SetActive(false);
    }
    public void quitgame()
    {
        Application.Quit();
    }

   
}
