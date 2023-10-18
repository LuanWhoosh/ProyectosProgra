using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoPequeno : MonoBehaviour
{
    private Rigidbody2D miCuerpo;
    private Animator miAnimador;
    public bool activo;
    public float velocidadCaminar = 5;
    private EfectosSonoros misSonidos;
    public GameObject splashBloodPrefab;


    void Start()
    {
        miCuerpo = GetComponent<Rigidbody2D>();
        miAnimador = GetComponent<Animator>();
        misSonidos = GetComponent<EfectosSonoros>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject zonaPeligro = collision.gameObject;
        if (zonaPeligro.tag == "Player")
        {
            float enemigo = zonaPeligro.transform.position.x;
            float heroe = this.transform.position.x;
            activo = true;

            if (heroe > enemigo)
            {
                transform.rotation = Quaternion.Euler(0, 180, 0);
                
            }
            else
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);
                
            }

            print(name + " entra a "
          + collision.gameObject);
          
        }
    } 

    private void OnTriggerExit2D(Collider2D collision)
    {
        GameObject zonaPeligro = collision.gameObject;
        if (zonaPeligro.tag == "Player")
        {
            activo = false;
            miAnimador.SetBool("CAMINANDO", false);

            print(name + " sale de "
          + collision.gameObject);
          
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject otroObjeto = collision.gameObject;
        if (otroObjeto.tag == "Player")
        {
            Personaje elPerso = otroObjeto.GetComponent<Personaje>(); // con esto le mando daño al personaje por 20 puntos y le digo que fue este objeto el que lo daño
            elPerso.hacerDanio(20, this.gameObject);
            GameObject efectoSpalsh
               = Instantiate(splashBloodPrefab);
            efectoSpalsh.transform.position
                = elPerso.transform.position;
            misSonidos.reproducir("daño");
            miAnimador.SetTrigger("DAÑO");
        }
    }

    void Update()
    {
        float velVert = miCuerpo.velocity.y;

        if (activo ==true)
        {
            miCuerpo.velocity = this.transform.right * velocidadCaminar;
            miAnimador.SetBool("CAMINANDO", true);
        }

    }
}
