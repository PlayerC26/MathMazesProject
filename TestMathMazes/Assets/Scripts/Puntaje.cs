using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Puntaje : MonoBehaviour
{
    public int puntaje;
    public string lvl;
    public int option = 0;



    private void Start()
    {
        puntaje= 100;
    }


    public void option1(string lvlo) //Valiacion de cada opcion de entrada
    {
         option = 1;
         lvl = lvlo;
        CalcularPuntaje(option);
    }
    public void option2(string lvlo)
    {
        option = 2;
        lvl = lvlo;
        CalcularPuntaje(option);
    }
    public void option3(string lvlo)
    {
        option = 3;
        lvl = lvlo;
        CalcularPuntaje(option);
    }

    public void CalcularPuntaje(int op)
    {
        Debug.Log("Respondido");

        if (option == 1 || option == 2) //Si la opcion es 1 o 2
        {
            puntaje = -25; //asigna el valor -25 a la variable  "puntaje"

            PlayerPrefs.SetFloat("PuntuacionPlayer", (PlayerPrefs.GetFloat("PuntuacionPlayer") + puntaje)); //aqui vamos a guardar el valor de PuntuacionPlayer para añadirle el valor de "puntaje"
            //para ello lo primero que hacemos es decirle que queremos guardar el dato (SetFloat) llamado "PuntuacionPlayer",
            //¿y qué valor le damos? pues le decimos que nos cargue el valor actual (GetFloat) y que le sume la variable puntaje
            //como en este caso puntaje es negativo, nos restará 25 puntos.
        }
        else
        {
            puntaje = 25;

            PlayerPrefs.SetFloat("PuntuacionPlayer", (PlayerPrefs.GetFloat("PuntuacionPlayer", 0) + puntaje)); //Aqui igual pero nos suma los puntos,
                                                                                                               //ya que en la linea anterior la variable puntaje tiene un valor positivo
            SceneManager.LoadScene("SelectC"); //Carga la escena llamada SelectC
        }

    
        
    }

}
