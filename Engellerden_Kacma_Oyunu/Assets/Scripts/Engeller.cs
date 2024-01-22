using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Engeller : MonoBehaviour
{
    public float hiz;
    private static int skor;

    public TextMeshProUGUI skoryazisi, bitisyazisi;
    void Start()
    {
        
    }
    
    
    void Update()
    {
        skoryazisi.text = "Skor:" + skor.ToString();
        bitisyazisi.text = "Oyun Bitti! \n Skor:" + skor.ToString();        
    }


     void OnCollisionEnter2D(Collision2D Temas)
    {
        float xpoziyonu = Random.Range(-7f, 7f);
        float ypozisyonu = Random.Range(5.81f, 14f);

        if(Temas.gameObject.tag=="Kontrol_Cubugu")
        {
            transform.position = new Vector2(xpoziyonu, ypozisyonu);
            skor += Random.Range(5, 10);
        }
        else if (Temas.gameObject.tag == "Karakter")
        {
            transform.position = new Vector2(xpoziyonu, ypozisyonu);
            Hak.kalanhak--;
        }
    }
}
