using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
[RequireComponent(typeof(AudioSource))]//anotacion
public class EfectosSonoros : MonoBehaviour
{
    public Efecto[] misEfectos; //atributo de efectos
    private AudioSource reproductor;

    private void Start()
    {
        reproductor = GetComponent<AudioSource>();
    }

    public void reproducir(string accion)
    {
        foreach(Efecto e in misEfectos)//por cada efecto en mis efectos, correra de forma automatica sin indices
        {
            //si la accion del efecto corresponda a la accion solicitada en el parametro
            if (e.accion == accion)//e es de public class efecto pero accion es de public void
            {
                //asigno el sonido al reproductor (audiosource)
                reproductor.clip = e.sonido; //clip es propiedad que se le asigna a cada sonido
                reproductor.Play();

                return;
            }
        }
    }
    [Serializable]
    public class Efecto
    {
        public string accion;
        public AudioClip sonido;
    }
}
