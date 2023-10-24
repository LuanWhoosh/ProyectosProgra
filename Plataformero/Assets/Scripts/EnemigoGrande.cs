using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoGrande : MonoBehaviour
{
    private Rigidbody2D miCuerpo;
    private Animator miAnimador;
    private GameObject heroeJugador;
    public bool activo;
    public float velocidadCaminar = 5;
    public int puntosDanio = 10;
    public float rangoAgro = 10;
    private EfectosSonoros misSonidos;
    public GameObject splashBloodPrefab;
    public float rangoAtaque = 3;

    void Start()
    {
        miCuerpo = GetComponent<Rigidbody2D>();
        miAnimador = GetComponent<Animator>();
        misSonidos = GetComponent<EfectosSonoros>();
        heroeJugador = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        Vector3 miPos = this.transform.position;
        Vector3 posHeroe = heroeJugador.transform.position;
        float distanciaHeroe = (miPos - posHeroe).magnitude;
        float velVert = miCuerpo.velocity.y;

        if (distanciaHeroe < rangoAgro && heroeJugador.GetComponent<Personaje>().estaVivo())
        {
            activo = true;
            print(heroeJugador + "el jugador se acerca a " + name);

            float heroe = heroeJugador.transform.position.x;
            float villano = this.transform.position.x;

            if (heroe > villano)
            {
                transform.rotation = Quaternion.Euler(0, 180, 0);
                
            }

            else
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);
                
            }

        }

        else
        {
            activo = false;
        }

        if (activo)
        {
            miCuerpo.velocity = this.transform.right * -velocidadCaminar;
            //miAnimador.SetBool("CAMINANDO", true);
            miAnimador.SetBool("CAMINANDO",true);

        }

        else
        {
            miCuerpo.velocity = Vector3.zero;
            //miCuerpo.velocity = this.transform.right * velocidadVill;
            miAnimador.SetBool("CAMINANDO", false);

        }

        if(distanciaHeroe < rangoAtaque && heroeJugador.GetComponent<Personaje>().estaVivo())

        {
            miAnimador.SetTrigger("GOLPEAR");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject otroObjeto = collision.gameObject;
        if (otroObjeto.tag == "Player" && heroeJugador.GetComponent<Personaje>().estaVivo())
        {
            Personaje elPerso = otroObjeto.GetComponent<Personaje>(); // con esto le mando daño al personaje por 20 puntos y le digo que fue este objeto el que lo daño
            elPerso.hacerDanio(10, this.gameObject);
            GameObject efectoSpalsh
               = Instantiate(splashBloodPrefab);
            efectoSpalsh.transform.position
                = elPerso.transform.position;
            misSonidos.reproducir("daño");
            miAnimador.SetTrigger("DAÑO");
        }
    }
}

