using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CambioEscena : MonoBehaviour
{
    private void Update(){
        int escena_actual = SceneManager.GetActiveScene().buildIndex;
        if(Input.GetKeyDown(KeyCode.P)){
            if(escena_actual == 0){
                cambioDeEscena(1);

            }
            else if(escena_actual == 1){
                cambioDeEscena(2);
            }
            else{
                cambioDeEscena(0);
            }
        }
    }


    public void cambioDeEscena(int index_escena_ir){
        SceneManager.LoadScene(index_escena_ir);
    }
}
