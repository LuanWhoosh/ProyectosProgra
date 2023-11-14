using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private EfectosSonoros misSonidos;
    private GameObject checkpoint;
    void Start()
    {
        misSonidos = GetComponent<EfectosSonoros>();
        checkpoint = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject otro = collision.gameObject;
        

        if (otro.tag == "Player")
        {
            print("El " + name + " colisiona con " + collision);
            Vector3 posCheck = this.transform.position;
            misSonidos.reproducir("SUCCES");
            print("La posicion de checkpoint " + posCheck);
        }
    }
}
