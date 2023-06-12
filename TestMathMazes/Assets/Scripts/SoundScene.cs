using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScene : MonoBehaviour
{

    private SoundScene instance; // Instancia de la clase
    private SoundScene Instance
    {
       get
       {
       return instance; //Retorna la instancia
       } 

    }
    private void Start() //Se usa en el metodo "Start()" para que cuando iniciel el juego de una vez active el SoundTrack
    {   

        //Este conjunto de IF indica que hay un GameObject donde se ingresa el audio de fondo para usarlo de manera estatica
        // y asi no se destruya al pasar a otra escena.
        if (FindObjectsOfType(GetType()).Length > 1) 
        {
            Destroy(gameObject);
        }
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }
        else
        {
            instance = this;
        }

        DontDestroyOnLoad(gameObject);

    }



}
