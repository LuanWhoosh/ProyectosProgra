using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cofre : MonoBehaviour
{
    private Animator miAnimador;
    public GameObject boton;
    void Start()
    {
        miAnimador = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject otro = collision.gameObject;
        print("El " + name + " colisiona con " + collision);

        if (otro.tag == "Player")
        {
            
            miAnimador.SetTrigger("TOMAR");
            boton.SetActive(true);
            pressBoton();

        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        GameObject otro = collision.gameObject;
        print("El" + name + " colisiona con " + collision);

        if (otro.tag == "Player")
        {
            miAnimador.SetTrigger("NORMAL");
            boton.SetActive(false);
            pressBoton();

        }
    }

    public void pressBoton()
    {
        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            Debug.Log("Keypad2 key was pressed.");

        }
    }



}
