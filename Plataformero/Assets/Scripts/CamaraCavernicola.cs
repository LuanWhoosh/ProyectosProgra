using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CamaraCavernicola : MonoBehaviour
{
    public Transform cavernicola;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(
            cavernicola.position.x,
            cavernicola.position.y,
            -1);
    }
}
