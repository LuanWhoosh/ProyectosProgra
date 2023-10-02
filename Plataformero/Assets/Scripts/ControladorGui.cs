using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorGui : MonoBehaviour
{
    public Personaje Heroe;
    public Text EtiquetaHPHeroe;
    public Image BarraHPHeroe;

    public Personaje Villano;
    public Text EtiquetaHPVillano;
    public Image BarraHPVillano;

    // Update is called once per frame
    void Update()
    {
        EtiquetaHPHeroe.text =
            Heroe.hp + "/" + Heroe.hpMax;
        float porcentajeHPHeroe
            = Heroe.hp / (float)Heroe.hpMax;
        BarraHPHeroe.fillAmount = porcentajeHPHeroe;

        EtiquetaHPVillano.text =
            Villano.hp + "/" + Villano.hpMax;
        float porcentajeHPVillano
            = Villano.hp / (float)Villano.hpMax;
        BarraHPVillano.fillAmount = porcentajeHPVillano;

    }
}
