using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class butonController : MonoBehaviour
{
    public GameObject ilkekran;
    public GameObject anamemen�Canvas;
    public GameObject b�l�m1;
    public GameObject b�l�n2;
    public GameObject b�l�m3;
    public GameObject b�l�m4;
    // Start is called before the first frame update
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void oynab�l�m1()
    {
        anamemen�Canvas.SetActive(false);
        b�l�m1.SetActive(true);
        b�l�n2.SetActive(false);
        b�l�m3.SetActive(false);
        b�l�m4.SetActive(false);

    }
    public void oynab�l�m2()
    {
        anamemen�Canvas.SetActive(false);
        b�l�m1.SetActive(false);
        b�l�n2.SetActive(true);
        b�l�m3.SetActive(false);
        b�l�m4.SetActive(false);


    }
    public void oynab�l�m3()
    {
        anamemen�Canvas.SetActive(false);
        b�l�m1.SetActive(false);
        b�l�n2.SetActive(false);
        b�l�m3.SetActive(true);
        b�l�m4.SetActive(false);

    }
    public void oynab�l�m4()
    {
        anamemen�Canvas.SetActive(false);
        b�l�m1.SetActive(false);
        b�l�n2.SetActive(false);
        b�l�m3.SetActive(false);
        b�l�m4.SetActive(true);
    }
    public void geributon()
    {
        ilkekran.SetActive(false);
        anamemen�Canvas.SetActive(true);
        b�l�m1.SetActive(false);
        b�l�n2.SetActive(false);
        b�l�m3.SetActive(false);
        b�l�m4.SetActive(false);

    }
    public void startbuton()
    {
        ilkekran.SetActive(false);
        anamemen�Canvas.SetActive(true);
        b�l�m1.SetActive(false);
        b�l�n2.SetActive(false);
        b�l�m3.SetActive(false);
        b�l�m4.SetActive(false);
    }
    public void quitgame()
    {
        Application.Quit();
    }

   
}
