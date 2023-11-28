using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapaParallax : MonoBehaviour
{
    public float porcentajeAlcance = 1;
    public float distanciaActualCamara;
    
    private Transform laCamara;
    public float diferenciaX;
    private float posInicial;


    public float anchoFondo = 20;
    public float anchoCamara = 18;

    void Start()
    {
        laCamara = Camera.main.transform;
        posInicial = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        float xCamaraActual = laCamara.position.x;
        float xCapaActual = transform.position.x;

        diferenciaX =
            xCamaraActual - posInicial;


        float distanciaReal = xCamaraActual - xCapaActual;
        float distanciaMax = anchoCamara / 2 + anchoFondo / 2;


        Vector3 posNueva;
        if (distanciaReal > distanciaMax)
        {
            float xNueva = xCamaraActual + distanciaMax;
            posNueva = new Vector3(
                xNueva,
                transform.position.y,
                transform.position.z);
        }
        else
        {
            diferenciaX = xCamaraActual - posInicial;
            posNueva = new Vector3(
                xCamaraActual - diferenciaX * porcentajeAlcance,
                transform.position.y,
                transform.position.z);
        }
        

        transform.position = posNueva;
    }
}

