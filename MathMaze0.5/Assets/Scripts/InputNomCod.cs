using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InputNomCod : MonoBehaviour
{
    //Variables como el nombre y codigo para empezar el juego

    public InputField inputName;
    public InputField inputCod;

    public Text txtNombre;
    public Text txtCod;

    public GameObject btnEmpezar;

    public Image luzName;
    public Image luzCod;

    public void Awake()
    {
        luzName.color = Color.red;
        luzCod.color = Color.red;
    }


    public void Update()
    {
        //Condicion para que se muestre verde o rojo, si cumple con la cantidad de caracteres necesaria para empezar(Codigo y nombre)
        if (inputName.text.Length < 3 )
        {
            luzName.color = Color.red;
            btnEmpezar.SetActive(false);

        }
        else
        {
            luzName.color = Color.green;
            btnEmpezar.SetActive(true);
        }

        if (inputCod.text.Length != 8)
        {
            luzCod.color = Color.red;
            btnEmpezar.SetActive(false);

        }
        else
        {
            luzCod.color = Color.green;
            btnEmpezar.SetActive(true);
        }

    }

    public void Empezar()
    {
        PlayerPrefs.SetString("nombreJugador", inputName.text );
        PlayerPrefs.SetString("codigoJugador", inputCod.text);

        SceneManager.LoadScene("Menu2");
    }


}
