using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Karakter_Hareketi : MonoBehaviour
{
    public float hiz;
    
    void Start()
    {
        
    }

    void Update()
    {
        float yataykontrol = Input.GetAxis("Horizontal") * hiz;

        transform.Translate(yataykontrol * Time.deltaTime, 0f, 0f);

        float xpozisyonu=Mathf.Clamp( transform.position.x, -7f,7f);
        transform.position = new Vector2(xpozisyonu, transform.position.y);
    }
}
