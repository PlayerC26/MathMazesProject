using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puntos : MonoBehaviour
{

    public string cadena;
    public int puntaje;
    public int puntajeT = 100;


 

    // Start is called before the first frame update
    void Start()
    {
        puntajeT = 100;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void sumaPuntaje()
    {
        if (cadena.Equals("mas"))
        {
            puntajeT += puntaje;
        }
        else if (cadena.Equals("menos"))
        {
            puntajeT -= puntaje;

        }
        else if (cadena.Equals("fin"))
        {
            puntajeT += puntaje;
            guardar();
        }

        
    }

    public void guardar()
    {

    }

   

}

public class Jugador
{
    private string name;
    private int cod;
    private int core;

    public Jugador(string nombre, int codigo,int cores )
    {
        name = nombre;
        cod = codigo;
        core = cores;
    }

}
