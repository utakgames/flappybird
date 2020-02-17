using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oyunkontrol : MonoBehaviour
{
    public GameObject g1;//gökyüzü 1
    public GameObject g2;//gökyüzü 2
    Rigidbody2D f1;//fizik 1
    Rigidbody2D f2;//fizik 2

    float uzunluk = 0;

    public GameObject engel;
    public int kt;//kaç tane engel oluşacak
    GameObject []engeller;
    float dzaman = 0;
    int s = 0;//sayaç
    
    void Start()
    {
        f1 = g1.GetComponent<Rigidbody2D>();
        f2 = g2.GetComponent<Rigidbody2D>();

        f1.velocity = new Vector2(-1.5f, 0);
        f2.velocity = new Vector2(-1.5f, 0);

        uzunluk = g1.GetComponent<BoxCollider2D>().size.x;

        engeller = new GameObject[kt];

        for(int i = 0; i < engeller.Length; i++)
        {
            engeller[i] = Instantiate(engel, new Vector2(-20, -20), Quaternion.identity);
            Rigidbody2D fizikengel= engeller[i].AddComponent<Rigidbody2D>();
            fizikengel.gravityScale = 0;
            fizikengel.velocity = new Vector2(-1.5f,0);
        }
    }

   
    void Update()
    {
        if (g1.transform.position.x<=-uzunluk)
        {
            g1.transform.position += new Vector3(uzunluk * 2,0);
        }
        if (g2.transform.position.x <= -uzunluk)
        {
            g2.transform.position += new Vector3(uzunluk * 2, 0);
        }

        dzaman += Time.deltaTime;
        if (dzaman > 2f)
        {
            dzaman = 0;
            float yekseni = Random.Range(-0.56f, 1.72f);
            engeller[s].transform.position = new Vector3(16, yekseni);
            s++;
            if (s >= engeller.Length)
            {
                s = 0;
            }
        }

    }
   public void oyunbitti()
    {
        for(int i = 0; i < engeller.Length; i++)
        {
            engeller[i].GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            f1.velocity = Vector2.zero;
            f2.velocity = Vector2.zero;
        }
    }
}

