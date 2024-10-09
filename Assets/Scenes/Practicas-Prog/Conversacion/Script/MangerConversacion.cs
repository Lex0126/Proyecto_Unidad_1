using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class MangerConversacion : MonoBehaviour
{
    [System.Serializable]
    public struct Dialogo{
        public string name;
        public string texto;
        public Sprite imagen;
    }
    public List<Dialogo> charla;
    [SerializeField] TextMeshProUGUI txt_mensaje;

    [SerializeField] TextMeshProUGUI txt_nombre;

    [SerializeField] Image foto_personaje;
    [SerializeField] CambioSCENE aux;

    int contador;

    void mostrarDialogo(){
     if (contador < charla.Count)
        {
            txt_mensaje.text = charla[contador].texto;
            txt_nombre.text = charla[contador].name;
            foto_personaje.sprite = charla[contador].imagen;
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
            if (contador < charla.Count - 1)
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
