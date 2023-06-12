using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Libreria necesaria para el cambio de escena

public class CambioEscena : MonoBehaviour
{
        //Entero que toma un valor segun el boton que vaya a cambiar de escena
    public int numEscena;


        //metodo de cambio de escena, toma el numero que envia el boton y este hace la carga de escena 
        // a la que se necesita
    public void cambioEscena() //Metodo para salir del juego, y un log para certificar que salio de la escena dentro de unity
    {
        SceneManager.LoadScene(numEscena);
        Cursor.visible = true;
    }


      
    public void exit() //Metodo para que el cambio de escena sea salir del juego
    {
        Application.Quit();
        Debug.Log("Juego finalizado");
    }


}








