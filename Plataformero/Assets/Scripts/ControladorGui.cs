using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorGui : MonoBehaviour
{
    public Personaje Heroe;
    public Text EtiquetaHPHeroe;
    public Image BarraHPHeroe;
   

    // Update is called once per frame
    void Update()
    {
        EtiquetaHPHeroe.text =
            Heroe.hp + "/" + Heroe.hpMax;
        float porcentajeHPHeroe
            = Heroe.hp / (float)Heroe.hpMax;
        BarraHPHeroe.fillAmount = porcentajeHPHeroe;
        
    }
}
