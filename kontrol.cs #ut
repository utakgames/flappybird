using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kontrol : MonoBehaviour
{
    public Sprite []kusSprite;
    SpriteRenderer spriteRenderer;
    bool ileriGeriKontrol = true;
    int kusSayac = 0;

    Rigidbody2D fizik;

    float kusAnimasyonZaman = 0;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        fizik = GetComponent<Rigidbody2D>();
    }

   
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            fizik.velocity = new Vector2(0,0);
            fizik.AddForce(new Vector2(0, 200));
        }
        if (fizik.velocity.y > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 45);
        }
        else
        {
            transform.eulerAngles = new Vector3(0, 0, -45);

        }
        Animasyon();
    }
        
    
    public void Animasyon()
    {
        kusAnimasyonZaman += Time.deltaTime;
        if (kusAnimasyonZaman > 0.2f)
        {
            kusAnimasyonZaman = 0;
            if (ileriGeriKontrol)
            {
                spriteRenderer.sprite = kusSprite[kusSayac];// publicte koyduğumuz resimleri ekrana sırayla getirerek animasyon gibi gözükmesini sağlayacak kod, fakat 3 resimimiz var ve diziler 0'dan başlar 0,1,2 den sonra 3 olunca hata verecektir bu yüzden 3 olunca ileriKontrolü false haline getirip else durumuna girmesini sağlıyoruz.
                kusSayac++;
                if (kusSayac == kusSprite.Length)
                {
                    kusSayac--;
                    ileriGeriKontrol = false;
                }

            }
            else
            {
                kusSayac--;
                spriteRenderer.sprite = kusSprite[kusSayac];
                if (kusSayac == 0)
                {
                    kusSayac++;
                    ileriGeriKontrol = true;
                }

            }
        }
    }
}
