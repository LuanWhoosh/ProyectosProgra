using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Veneno : MonoBehaviour
{
    private Personaje elPerso;
    public int puntosDanio = 20;
    public float repetirDanio = 2f;

    void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject otroObjeto = collision.gameObject;

        if (otroObjeto.CompareTag("Player"))
        {
            elPerso = otroObjeto.GetComponent<Personaje>();

            InvokeRepeating("HacerDanioRepetido", 0f, repetirDanio);
            Destroy(gameObject, 10);
        }
    }

    void HacerDanioRepetido()
    {
        if (elPerso != null)
        {
            elPerso.hacerDanio(puntosDanio, this.gameObject);
            elPerso.quitarVidas();
        }
    }
}
