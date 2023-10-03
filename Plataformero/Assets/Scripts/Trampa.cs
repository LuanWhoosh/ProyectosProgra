using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampa : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {//este metodo se ejecuta cuando este objeto detecta una colision
        GameObject otroObjeto = collision.gameObject;

        if (otroObjeto.tag == "Player")
        {
            print(name + "detecte colision con"
            + collision.gameObject);
            //con esta instrucciones obtengo el componente personaje del player
            Personaje elPerso = otroObjeto.GetComponent<Personaje>();
            // con esto le mando daño al personaje por 20 puntos y le digo que fue este objeto el que lo daño
            elPerso.hacerDanio(20, this.gameObject);
        }
        
    }
}
