using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{
    public int puntosAtaque = 30;
    void update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject otro = collision.gameObject;
        print( "Arma "+ name + " colisiona con " + collision);

        if (otro.tag == "Enemigo")
        {
            
            Personaje enemigo = otro.GetComponent<Personaje>();
            enemigo.hacerDanio(puntosAtaque, this.gameObject);

        }
    }
}
