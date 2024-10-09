using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MangenerImg : MonoBehaviour

{
    [System.Serializable]
    public struct Dialogo{
    
        public Sprite imagen;
    }
    public List<Dialogo> Img;
    [SerializeField] Image foto_personaje;

    int contador;

    void mostrarDialogo(){
       
        foto_personaje.sprite = Img[contador].imagen;
    }
    // Start is called before the first frame update
    void Start()
    {
         contador =  0;
        mostrarDialogo();
        
    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetKeyDown(KeyCode.C)){
            contador++;
            contador%=Img.Count;
            mostrarDialogo();
           /* if(charla.Count ==30){
            aux.cambioDeEscena(2);
        }*/
        }
    }
}
