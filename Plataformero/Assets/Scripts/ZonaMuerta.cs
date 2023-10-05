using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonaMuerta : MonoBehaviour
{

    public GameObject splashAguaPrefab;
    public GameObject heartBrokenPrefab;

    
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

            GameObject efectoSpalsh
                = Instantiate(splashAguaPrefab);
            efectoSpalsh.transform.position
                = elPerso.transform.position;

            //GameObject efectoHeartBroken
            //  = Instantiate(heartBrokenPrefab);
            //efectoHeartBroken.transform.position
            //  = elPerso.transform.position;

            GameObject efectoHeartBroken = Instantiate(heartBrokenPrefab);
            Vector3 nuevaPosicion = elPerso.transform.position;
            nuevaPosicion.y += 3.0f; 
            efectoHeartBroken.transform.position = nuevaPosicion;

        }
    }

}
