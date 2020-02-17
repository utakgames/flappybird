using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hareketanimasyon : MonoBehaviour
{
    public Sprite[] kus;
    SpriteRenderer sr;//sprite renderer
    bool ilerigerikontrol = true;
    float zaman = 0;
    int ks = 0;//ks=kuş sayaç
    Rigidbody2D fizik;
    int puan = 0;
    public Text puantext;
    bool oyunbitti = true;
    oyunkontrol oyunkontrol;
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        fizik = GetComponent<Rigidbody2D>();
        oyunkontrol = GameObject.FindGameObjectWithTag("oyunkontroltag").GetComponent<oyunkontrol>();
    }

    
    void Update()
    {
        if (Input.GetMouseButton(0)&& oyunbitti)
        {
            fizik.velocity = new Vector2(0, 0);
            fizik.AddForce(new Vector2(0, 100));
        }
        if (fizik.velocity.y > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 30);
        }
        else
        {
            transform.eulerAngles = new Vector3(0, 0, -30);
        }
        Animasyon();
    }
    void Animasyon()
    {
        zaman += Time.deltaTime;
        if (zaman > 0.1f)
        {
            zaman = 0;
            if (ilerigerikontrol)
            {
                sr.sprite = kus[ks];
                ks++;
                if (ks == kus.Length)
                {
                    ks--;
                    ilerigerikontrol = false;
                }
            }
            else
            {
                ks--;
                sr.sprite = kus[ks];
                if (ks == 0)
                {
                    ks++;
                    ilerigerikontrol = true;
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "puan")
        {
            puan++;
            puantext.text = "SKOR=" + puan;

        }
        if (col.gameObject.tag == "engel")
        {
            oyunbitti = false;
            oyunkontrol.oyunbitti();
        }
    }
}
