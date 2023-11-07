using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Personaje : MonoBehaviour
{
    public int hp = 70;
    public int hpMax = 100;
    public static int vidas = 5;
    public int vidasMax = 5;
    public int score = 0;
    public int scoreMax = 350;
    public bool bloqueado = false;
    public int dinero = 0;


    public GameObject heartBrokenPrefab;
    private Animator miAnimador;
    private EfectosSonoros misSonidos;
    private Personaje miPersonaje;
    //private Tesoro miTesoro;
    

    void Start()
    {
        miAnimador = GetComponent<Animator>();
        misSonidos = GetComponent<EfectosSonoros>();
        miPersonaje = GetComponent<Personaje>();
        //miTesoro = GetComponent<Tesoro>();
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public bool estaVivo()
    {
        return  hp > 0;
    }

    private void desbloquear()
    {
        bloqueado = false;
    }
    //cuanto daño te hace y quien
    public void hacerDanio(int puntosDanio, GameObject enemigo)
    {
        if (miPersonaje.estaVivo())
        {
            hp = hp - puntosDanio;
            bloqueado = true;
            //dentro de 1.2 segundos se va a ejecutar el metodo llamado desbloquear
            Invoke("desbloquear", 1.2f);
            print(name + "recibe daño de " + puntosDanio + "por" + enemigo);


            if (hp > 0)
            {
                misSonidos.reproducir("daño");
                miAnimador.SetTrigger("DAÑO");

            }
            if (hp <= 0)
            {
                miAnimador.SetTrigger("MUERTE");
                misSonidos.reproducir("muerte");
                vidas = vidas - 1;
            }
        }
        
    }

    public void muerteInstan(int reducirVida, GameObject deadZone)
    {
        if (miPersonaje.tag == "Player")
        {
            vidas = vidas - reducirVida;
            hp = 0;
            print(name + "se reduce " + reducirVida + "vida por" + deadZone);
            miAnimador.SetTrigger("MUERTE");
            misSonidos.reproducir("muerte");
        }
        
    }


    public void quitarVidas()
    {

        if (hp <= 0)
        {
            GameObject efectoHeartBroken = Instantiate(heartBrokenPrefab);
            efectoHeartBroken.transform.position = this.transform.position;

            if (miPersonaje.tag == "Player")
            {
                if (vidas > 0)
                {
                    Invoke("reiniciarEscena", 3);
                }
            }
            
        }
    }

    

   private void reiniciarEscena()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
      

    public bool gameOver()
    {
        return(vidas<= 0);
    }

    //public void contadorDinero()
    //{
        //dinero = miTesoro.valor + dinero;
    //}
}
