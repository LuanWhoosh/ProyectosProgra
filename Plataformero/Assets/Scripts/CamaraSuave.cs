using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraSuave : MonoBehaviour
{
    public Personaje objetivo;
    public float offsetProfundidad = -5;
    public float offsetVertical = -1;
    public float velocidadAlcance = 2;//tiempo que le toma llegar

    private void LateUpdate()//se ejecuta cada frame despues de cada update, permite estabilidad
    {
        Vector3 posDestino = new Vector3(
            objetivo.transform.position.x, 
            objetivo.transform.position.y + offsetVertical,
            objetivo.transform.position.z + offsetProfundidad);

        transform.position = Vector3.Lerp(
            transform.position, posDestino,
            Time.deltaTime * velocidadAlcance);
    }


}
