using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorJugador : MonoBehaviour
{
    public float velocidadCaminar = 5;
    public float fuerzaSalto = 4;
    public bool enPiso = false;
    public int contadorSaltos;


    private Rigidbody2D miCuerpo;
    private Animator miAnimador;
    private EfectosSonoros misSonidos;
    // Start is called before the first frame update
    void Start()
    {
        miCuerpo = GetComponent<Rigidbody2D>();
        miAnimador = GetComponent<Animator>();
        misSonidos = GetComponent<EfectosSonoros>();
    }

    // Update is called once per frame
    void Update()
    {
        //Lo primero que hago en el update es detectrar el piso
        detectarPiso();

        
        float velVert = miCuerpo.velocity.y;
        float movHoriz = Input.GetAxis("Horizontal");


        if (movHoriz > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            miCuerpo.velocity = new Vector3(velocidadCaminar, velVert, 0);
            miAnimador.SetBool("CAMINANDO", true);
        }
        else if (movHoriz < 0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
            miCuerpo.velocity = new Vector3(-velocidadCaminar, velVert,0);
            miAnimador.SetBool("CAMINANDO", true);
        }
        else
        {
            miCuerpo.velocity = new Vector3(0, velVert, 0);
            miAnimador.SetBool("CAMINANDO", false);
        }

        if (enPiso == true)
        {
            contadorSaltos = 2;
        }
        else if (Input.GetButtonDown("Jump") && contadorSaltos >  0)
            {
                contadorSaltos --;
            }
         if (Input.GetButtonDown("Jump") && contadorSaltos > 0)
            {
                miCuerpo.AddForce(new Vector3(0, fuerzaSalto, 0), ForceMode2D.Impulse);
                misSonidos.reproducir("salto");

            }

         if(Input.GetButtonDown("Fire1"))
        {
            miAnimador.SetTrigger("GOLPEAR");
        }
       
       
         
        

        miAnimador.SetFloat("VEL_VERT", velVert);
    }//fin del update

    void detectarPiso()
        {
            enPiso = Physics2D.Raycast(
                transform.position,//desde donde sale el rayo
                Vector2.down,//en que direccion
                0.1f// que tan largo
                );
        }
}//fin de la clase
