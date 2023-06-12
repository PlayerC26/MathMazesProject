using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class PlayerController : MonoBehaviour
{
    public float walkspeed = 5f; //Se crea una variable de tipo float para darle un valor y usarlo para la velocidad al caminar

    Vector3 moveInput = Vector3.zero;
    CharacterController charactercontroller;

    private void Awake() {

        charactercontroller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        moveInput = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")); // de a cuerdo a la configuracion de unity,
                                                                                             // se usa los movimiento verticales y horizontales
                                                                                             // para guiar el personaje del juego
        moveInput = transform.TransformDirection(moveInput) * walkspeed; //se usa un tansform para transformar el objeto de acuerdo
                                                                         //al movimiento con relacion a la velocidad que se le indico
                                                                         //con la variable anterior.
        charactercontroller.Move(moveInput*Time.deltaTime);
    }

}
