using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject nube = collision.gameObject;

        if (nube.tag == "Player")
        {

            print(name + "detecte colision con"
            + collision.gameObject);
            //con esta instrucciones obtengo el componente personaje del player
            Personaje elPerso = nube.GetComponent<Personaje>();
            // con esto le mando da�o al personaje por 20 puntos y le digo que fue este objeto el que lo da�o
            elPerso.muerteInstan(1, this.gameObject);
            elPerso.quitarVidas();
            

        }
    }
    void Update()
    {
        
    }
}
