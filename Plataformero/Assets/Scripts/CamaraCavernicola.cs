using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CamaraCavernicola : MonoBehaviour
{
    public Personaje cavernicola;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (cavernicola.estaVivo()) 
        {
            transform.position = new Vector3(
            cavernicola.transform.position.x,
            cavernicola.transform.position.y,
            -1);
        }
        
    }
}
