using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPausa : MonoBehaviour
{

    public GameObject menuDePausa;
    private bool menuOn;

   /* public void pausa()

    {
        Time.timeScale = 0f;
    }*/

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            menuOn = !menuOn;
        }

            if(menuOn == true)
            {
                menuDePausa.SetActive(true);
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
            else
            {
                menuDePausa.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
    
    }

    public void continuar()
    {
        menuDePausa.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        menuOn = false;
    }
    
}
