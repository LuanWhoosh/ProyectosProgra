using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{

    void update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject golpeArma = collision.gameObject;
        

        if (golpeArma.tag == "Enemigo")
        {
            print(name + " golpeo a "
            + collision.gameObject);
            Personaje enemigo = golpeArma.GetComponent<Personaje>();
            enemigo.hacerDanio(15, this.gameObject);

        }
    }
}
