using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OcultarMouse : MonoBehaviour
{
    public void OcultarPuntero() //Se crea un metodo para cuando se inicie una escena de juego, el puntero del mouse se oculte y solo quede la mira del jugador
    {
        Cursor.visible = false; //Indica que el Cursor deja de ser visible
        Cursor.lockState = CursorLockMode.Locked; // Por lo tanto, debe quedar bloqueado

    }
    public void ActivarPuntero() // Se crea un metodo para cuando termine el nivel y se vuelva a activar el mouse y el jugador pueda interactuar con los botones
    {
        Cursor.visible = true; // se hace visible el Cursor
        Cursor.lockState = CursorLockMode.None; // y se desbloquea para que pueda moverse 

    }

}
