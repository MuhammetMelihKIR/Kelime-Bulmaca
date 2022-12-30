using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class oyun : MonoBehaviour
{
    public List<Transform> kareler;
    public List<int[]> diziler = new List<int[]>();
    public int[] dizi1;
    public int[] dizi2;
    public int[] dizi3;
    public int[] dizi4;
    public int[] dizi5;
    public int[] dizi6;
    public int[] dizi7;
    public bool tebrik = false;
   
    public List<string> kelimeler;

    // Start is called before the first frame update
    void Start()
    {
        diziler.Add(dizi1);
        diziler.Add(dizi2);
        diziler.Add(dizi3);
        diziler.Add(dizi4);
        diziler.Add(dizi5);
        diziler.Add(dizi6);
        diziler.Add(dizi7);
    }

    // Update is called once per frame
    void Update()
        
    {
        
        if (ClickController.kontrol == true)
        {
            
            ClickController.kontrol = false;
            for (int i = 0; i < kelimeler.Count; i++)
            {
                if (ClickController.girilen == kelimeler[i])
                {
                    int[] indis = diziler[i]; 
                    for (int j = 0; j < kelimeler[i].Length; j++)
                    {
                        kareler[indis[j]].GetComponent<TextMesh>().text = ClickController.girilen[j].ToString();
                       
                       
                    }
                }
            }
            ClickController.girilen = "";
        }
         
       
    }
    
}
