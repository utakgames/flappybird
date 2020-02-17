using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyunKontrol : MonoBehaviour
{
    public GameObject gokyuzuBir;
    public GameObject gokyuzuIki;

    Rigidbody2D fizikBir;
    Rigidbody2D fizikIki;

    public float arkaPlanHizi;

    float uzunluk = 0;
    void Start()
    {
        fizikBir = gokyuzuBir.GetComponent<Rigidbody2D>();
        fizikIki = gokyuzuIki.GetComponent<Rigidbody2D>();

        fizikBir.velocity = new Vector2(arkaPlanHizi, 0);
        fizikIki.velocity = new Vector2(arkaPlanHizi, 0);

        uzunluk = gokyuzuBir.GetComponent<BoxCollider2D>().size.x;
    }

    
    void Update()
    {
        if (gokyuzuBir.transform.position.x <= - uzunluk)
        {
            gokyuzuBir.transform.position.x += new Vector3(uzunluk * 2, 0);
        }
        if (gokyuzuIki.transform.position.x <= - uzunluk)
        {
            gokyuzuIki.transform.position.x += new Vector3(uzunluk * 2, 0);
        }
    }
}
