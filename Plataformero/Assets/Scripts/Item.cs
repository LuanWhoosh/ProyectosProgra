using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    private EfectosSonoros misSonidos;
    private Animator miAnimador;
    private ControladorJugador persoPlayer;
    private Collider2D miCollider;
    public int boostInc = 2;


    void Start()
    {
        misSonidos = GetComponent<EfectosSonoros>();
        miAnimador = GetComponent<Animator>();
        miCollider = GetComponent<Collider2D>();
    }

  
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject otro = collision.gameObject;

        if (otro.CompareTag("Player"))
        {
            
            
            CapsuleCollider2D collisionJugador = otro.GetComponent<CapsuleCollider2D>();

            if (collisionJugador != null && collision == collisionJugador)
            {
                print(name + " colisiono " + otro);

                persoPlayer = otro.GetComponent<ControladorJugador>();

                if (persoPlayer != null)
                {
                    
                    persoPlayer.velocidadCaminar = persoPlayer.velocidadCaminar* boostInc;
                    miAnimador.SetTrigger("RECOGER");
                    misSonidos.reproducir("manzanita");
                    Invoke("velocidadOrig", 2.9f);
                    Invoke("destruirObjeto", 3);
                    Invoke("colliderOut", 0.1f);
                }
            }
        }
    }


    public void velocidadOrig()
    {
        Debug.Log("Velocidad orginal"); 
        if (persoPlayer != null)
        {
            persoPlayer.velocidadCaminar = persoPlayer.velocidadCaminar/ boostInc;
            Debug.Log("Velocidad caminar = " + persoPlayer.velocidadCaminar);
        }
    }


    public void destruirObjeto()
    {
        Destroy(gameObject);
        Debug.Log("bye objeto");
    }

    private void colliderOut()
    {
        if (miCollider != null)
        {
            miCollider.enabled = false;
        }
    }
}
