using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camaraenpelota : MonoBehaviour
{
    //atributo fisico publico
    public Transform Pelota;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(
            Pelota.position.x,
            Pelota.position.y,
            -1);
        
    }
}
