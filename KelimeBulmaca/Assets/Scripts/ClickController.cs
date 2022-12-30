using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickController : MonoBehaviour
{
    public static string girilen = "";
    public static bool ilktik=false;
    public bool aktif = true;
    public static bool kontrol = false;    
    TextMesh text;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (ilktik == false) 
        {
            text=GetComponent<TextMesh>();
            text.color=Color.white;
            aktif=true;
        }
    }
    public void tiklandi()
    {
        text=GetComponent<TextMesh>();
        text.color=Color.yellow;
        girilen += GetComponent<TextMesh>().text;
        Debug.Log(girilen);
        aktif = false;
    }
    private void OnMouseDown()
    {
        if (ilktik == false)
        {
            tiklandi();
            
            ilktik = true;
        }

    }
    private void OnMouseEnter()
    {
        if (ilktik == true && aktif == true)
        {
            tiklandi();
        }
    }
    private void OnMouseUp()
    {
        ilktik = false;
        
        kontrol = true;
    }
}
