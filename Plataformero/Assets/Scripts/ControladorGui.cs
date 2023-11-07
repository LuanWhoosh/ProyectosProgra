using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorGui : MonoBehaviour
{
    public Personaje Heroe;
    public Text EtiquetaHPHeroe;
    public Image BarraHPHeroe;
    public Text EtiquetaScoreHeroe;
    public Text EtiquetaVidaHeroe;
    public Text EtiquetaMoneda;

    public Personaje Villano;
    public Text EtiquetaHPVillano;
    public Image BarraHPVillano;
    //public Image GameOver;
    public GameObject GameOver;



    // Update is called once per frame
    void Update()
    {
        EtiquetaHPHeroe.text =
            Heroe.hp + " / " + Heroe.hpMax;
        float porcentajeHPHeroe
            = Heroe.hp / (float)Heroe.hpMax;
        BarraHPHeroe.fillAmount = porcentajeHPHeroe;

        EtiquetaScoreHeroe.text =
            Heroe.score + " / " + Heroe.scoreMax;
        EtiquetaVidaHeroe.text =
            Personaje.vidas + " / " + Heroe.vidasMax;

        EtiquetaHPVillano.text =
            Villano.hp + " / " + Villano.hpMax;
        float porcentajeHPVillano
            = Villano.hp / (float)Villano.hpMax;
        BarraHPVillano.fillAmount = porcentajeHPVillano;

        EtiquetaMoneda.text = Heroe.dinero + "";

        if (Heroe.gameOver())
        {
            GameOver.SetActive(true);
        }

    }

    
   
        

}
