using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controladorjugador : MonoBehaviour
{
    public float fuerzaSalto = 5;
    //Referencia al componentre rigid body

    private Rigidbody2D miCuerpo;
    // Start is called before the first frame update
    void Start()
    {
        //se obtiene el componente
        miCuerpo = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump") )
        {
            print("Se presiono alto");
            //Aplico una fuerza por impulso
            //en el eje de las Y
            miCuerpo.AddForce(
                new Vector3(0, fuerzaSalto, 0),
                ForceMode2D.Impulse);


        }
    }

}
