using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    public int hp = 70;
    public int hpMax = 100;
    public int vidas = 3;
    public int vidasMax = 5;
    public int score = 0;
    public int scoreMax = 350;

    public GameObject heartBrokenPrefab;
    private Animator miAnimador;
    private EfectosSonoros misSonidos;


    void Start()
    {
        miAnimador = GetComponent<Animator>();
        misSonidos = GetComponent<EfectosSonoros>();
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    //cuanto daño te hace y quien
    public void hacerDanio(int puntosDanio, GameObject enemigo)
    {
        hp = hp - puntosDanio;
        print(name + "recibe daño de " + puntosDanio + "por" + enemigo);
        

        if (hp>0)
        {
            misSonidos.reproducir("daño");
            miAnimador.SetTrigger("DAÑO");
            
        }
        if (hp<=0)
        {
            miAnimador.SetTrigger("MUERTE");
            misSonidos.reproducir("muerte");
            vidas = vidas - 1;
        }
    }

    public void muerteInstan(int reducirVida, GameObject deadZone)
    {
        vidas = vidas- reducirVida;
        hp = 0;
        print(name + "se reduce " + reducirVida + "vida por" + deadZone);
        miAnimador.SetTrigger("MUERTE");
        misSonidos.reproducir("muerte");
    }


    public void quitarVidas()
    {

        if (hp <= 0)
        {
            GameObject efectoHeartBroken = Instantiate(heartBrokenPrefab);
            efectoHeartBroken.transform.position = this.transform.position;
        }
    }
      

}
