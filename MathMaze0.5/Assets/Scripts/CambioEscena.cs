using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour
{
    public int numEscena;

    public void cambioEscena()
    {
        SceneManager.LoadScene(numEscena);
    }

    public void exit()
    {
        Application.Quit();
        Debug.Log("Juego finalizado");
    }


}
