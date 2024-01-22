using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Hak : MonoBehaviour
{
    public static int kalanhak = 3;
    public TextMeshProUGUI HakYazisi;
    public GameObject Bitispaneli;
    void Start()
    {
        
    }

    
    void Update()
    {

        HakYazisi.text="Hak:"+kalanhak.ToString();

        if (kalanhak == 0)
        {
            Time.timeScale = 0;
            Bitispaneli.SetActive(true);
        }
   
    }
}
