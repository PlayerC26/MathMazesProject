using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PuntuacionUsuario : MonoBehaviour 
{
    private const string DefaultValue = " ";
    [HideInInspector] public TextMeshProUGUI text;   //El texto que corresponde a la puntuacion


    static PuntuacionUsuario puntuacionPlayer; //Aqui hacemos una referencia a esta clase para conservarla posteriormente entre escenas. 


    void Start()
    {
         

        
    }


    void Awake()
    {


        if (puntuacionPlayer == null) //Si es la primera vez que se carga este codigo entonces:
        {
            puntuacionPlayer = this; //le decimos que este objeto se acaba de cargar
            DontDestroyOnLoad(this); //con esta linea hacemos que no se destruya al cargar otra escena
        }
        else
        {
            Destroy(gameObject); //esta linea destruye este objeto si esta duplicado, para que solo haya uno
        }
    }

    // Update is called once per frame
    void Update()
    {
 
        

        if (PlayerPrefs.GetFloat("PuntuacionPlayer")<=0)   //Le decimos que cargue el valor "PuntuacionPlayer", y si ese valor es menor a 0 entonces:   
        {
            PlayerPrefs.SetFloat("PuntuacionPlayer", 0); //entonces le asigna el valor 0.

            //PlayerPrefs.GetFloat -> Esto es para CARGAR el valor de un dato
            //PlayerPrefs.SetFloat -> Esto es para GUARDAr, para asignar un nuevo valor a ese dato.

            //Ejemplo: En la linea 35 le estoy asignando un valor de 0 a la varaible PuntuacionPlayer.  
            //En la linea 50 se consulta (Get) si ese valor es inferior a 0.
        }

        text.text = "Puntuacion: " + PlayerPrefs.GetFloat("PuntuacionPlayer", 100).ToString(); //Le decimos que el texto es igual a la palabra "Puntuacion"
                                                                                               //y que añada el valor numérico guardado en PlayerPrefs para la variable "PuntuacionPlayer"
        
    }
}
