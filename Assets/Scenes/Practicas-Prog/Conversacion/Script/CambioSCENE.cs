using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioSCENE : MonoBehaviour
{
    // Start is called before the first frame update

    
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Obtén la escena actual
            int escena_actual = SceneManager.GetActiveScene().buildIndex;

            // Carga la siguiente escena
            SceneManager.LoadScene(escena_actual + 1);
        }
    }
    public void cambioDeEscena(){
         int escena_actual = SceneManager.GetActiveScene().buildIndex;

        // Carga la siguiente escena
        SceneManager.LoadScene(escena_actual + 1);
    }
}
