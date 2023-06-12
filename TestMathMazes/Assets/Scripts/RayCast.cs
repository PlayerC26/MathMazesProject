using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RayCast : MonoBehaviour
{   
    private new Transform camera;
    public float rayDistance; //Variable para la distancia del rayo que ejecuta la accion al tocar un objeto 

    void Start()
    {
        camera = transform.Find("Camera"); //Transforma el objeto llamado "camera" cuando inicia el juego
    }


    void Update()
    {
       
        Debug.DrawRay(camera.position , camera.forward * rayDistance, Color.red); //hace un debug donde muestra el rayo que interactua con el objeto, teniendo en cuenta la distancia y el color que se le da

        RaycastHit hit; // Variable

        if(Physics.Raycast(camera.position, camera.forward, out hit, rayDistance, LayerMask.GetMask("Interactable"))){ //Indica que si el rayo o RayCast toca algun objeto con el layer " Interactable" puede ejecutar 
            // x accion

            Debug.Log(hit.transform.name); // debug para verificar si esta interactuando con el objeto

           if (hit.transform.gameObject.GetComponent<Button>() != null)  //Si el ray cast le da a un objeto que TIENE el componente Button
            {
                if (Input.GetMouseButtonDown(0)) //si tras eso pulsamos el click izquierdo del mouse
                {
                    hit.transform.gameObject.GetComponent<Button>().onClick.Invoke(); //entonces se activa la funcion que tenga asignada ese boton, en este caso
                                                                                      //sería "opcion 1" o "opcion 2" o opcion 3, la que tenga asignada el objeto al que le dio el raycast.

                }
            }

        }
    }


    
}
