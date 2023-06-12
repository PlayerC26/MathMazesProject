using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorrarDatos : MonoBehaviour
{
    float tiempo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.P)) //Si mantengo pulsada la P
        {
            tiempo += Time.deltaTime; //aumenta una varaible llamada "tiempo" en funcion del tiempo que haya transcurrido desde q tenemos la P presionada
            if (tiempo>=5) //Si ese tiempo es mayor a 5 segundos entonces ejecuta la funcion BorrarPuntuacion
            {
                BorrarPuntuacion();
            }
        }


        if (Input.GetKeyUp(KeyCode.P)) //Si levanto la tecla P me reinicia el contador de tiempo a 0.
        {
            tiempo = 0;
        }
        
    }


    public void BorrarPuntuacion()
    {
        PlayerPrefs.SetFloat("PuntuacionPlayer", 100); //Le pone el valor 100 a la variable de puntuacion como puntaje base
        Debug.Log("Puntuacion restablecida");
    }
}
