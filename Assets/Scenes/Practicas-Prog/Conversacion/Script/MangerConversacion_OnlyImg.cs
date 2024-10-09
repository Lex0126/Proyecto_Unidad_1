using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class MangerConversacion_OnlyImg : MonoBehaviour
{
    [System.Serializable]
    public struct Dialogo{
        public string texto;
    
        public Sprite imagen;
    }
    public List<Dialogo> Img;
    
    [SerializeField] TextMeshProUGUI txt_mensaje;
    [SerializeField] Image foto_personaje;

    [SerializeField] CambioSCENE aux;
    

    int contador;

    void mostrarDialogo(){
         if (contador < Img.Count)
        {
            txt_mensaje.text = Img[contador].texto;
            foto_personaje.sprite = Img[contador].imagen;
        }
        
    }

    void Start()
    {
        contador =  0;
        mostrarDialogo();
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKeyDown(KeyCode.C))
        {
            if (contador < Img.Count - 1)
            {
                contador++;
                mostrarDialogo();
            }
            else
            {
             
                aux.cambioDeEscena(); 
            }
        }
        
    }
}
