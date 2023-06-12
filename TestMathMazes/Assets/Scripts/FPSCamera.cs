using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FPSCamera : MonoBehaviour
{   
    private new Transform camera;
    public Vector2 sensibility; //Se usa una variable de Tipo Vector2 para la sensibilidad de movimiento

    void Start()
    {
        camera = transform.Find("Camera");
    }

    // Update is called once per frame
    void Update()
    {
        
        float hor = Input.GetAxis("Mouse X");
        float ver = Input.GetAxis("Mouse Y");//se le da valor a cada varaible con el movimiento en X y Y del mouse
        if (hor != 0)
        {
            transform.Rotate(Vector3.up * hor * sensibility.x); // crea el movimiento o la rotacion con el vector de acuerdo a las variables anteriores
        }

        if (ver != 0)
        {
            // camera.Rotate(Vector3.left*ver*sensibility.y);
            float angle = (camera.localEulerAngles.x - ver * sensibility.y + 360) % 360; //Se le pone un limite de movimiento, para que la camara no pase de largo arriba o abajo
            //angle = Mathf.Clamp(angle , -80, 80);
            camera.localEulerAngles = Vector3.right * angle; 
        }

    }
}