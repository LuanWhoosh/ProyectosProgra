using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject otro = collision.gameObject;
        print("La " + name + " colisiona con " + collision);

        if (otro.tag == "Player")
        {
            ControladorJugador elPerso = otro.GetComponent<ControladorJugador>();
            elPerso.velocidadCaminar = elPerso.velocidadCaminar * 2;
            Destroy(gameObject, 3);



        }


    }
}
