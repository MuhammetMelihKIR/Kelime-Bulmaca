using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sescontroller : MonoBehaviour
{
    public bool sesaktif = true;
    public AudioSource audio;
    
    // Start is called before the first frame update
    void Start()
    {
        audio=GetComponent<AudioSource>();  
    }

    // Update is called once per frame
    void Update()
    {
        if (sesaktif == true)
        {
            audio.Play();
        }
        if(sesaktif == false)
        {
            audio.Pause();
        }
    }
    public void sesayarý()
    {
        if (sesaktif == true)
        {
            sesaktif = false;
        }
        
        if(sesaktif == false)
        {
            sesaktif = true;
        }
           
    }
}
