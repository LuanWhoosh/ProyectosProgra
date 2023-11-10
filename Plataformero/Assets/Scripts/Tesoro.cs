using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tesoro : MonoBehaviour
{
    public int valor = 1;

    private EfectosSonoros misSonidos;
    private Animator miAnimador;

    private void Start()
    {
        misSonidos = GetComponent<EfectosSonoros>();
        miAnimador = GetComponent<Animator>();
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject otro = collision.gameObject;
        print("La " + name + " colisiona con " + collision);

        if (otro.tag == "Player")
        {
            Personaje elPerso = otro.GetComponent<Personaje>();
            elPerso.dinero = elPerso.dinero + valor;
            misSonidos.reproducir("onecoin");
            miAnimador.SetTrigger("DESAPARECER");
            Destroy(gameObject,0.4f);
        }


    }

    
}
