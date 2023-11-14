using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cofre : MonoBehaviour
{
    private Animator miAnimador;
    public GameObject boton;
    public GameObject cofreEpico;
    public bool puedesPres = false;
    

    void Start()
    {
        miAnimador = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("m") && puedesPres == true)
        {
            miAnimador.SetTrigger("TOMAR");
            
            boton.SetActive(false);
            Destroy(gameObject, 1f);
            this.instanciarItem();

        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject otro = collision.gameObject;

        if (otro.tag == "Player")
        {
            print("El " + name + " colisiona con " + collision);
            boton.SetActive(true);
            puedesPres = true;
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        GameObject otro = collision.gameObject;

        if (otro.tag == "Player")
        {
            print("El" + name + " colisiona con " + collision);
            miAnimador.SetTrigger("NORMAL");
            boton.SetActive(false);
            puedesPres = false;
        }
    }

    private void instanciarItem()
    {
        Instantiate(cofreEpico, transform.position, Quaternion.identity);
    }



}
