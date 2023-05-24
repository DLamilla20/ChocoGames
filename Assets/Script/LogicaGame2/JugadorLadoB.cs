using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class JugadorLadoB : MonoBehaviour
{
    public int puntaje = 0;
    public GameObject texto;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TextMeshProUGUI etiquetaPuntaje1 = this.texto.GetComponent<TextMeshProUGUI>();
        etiquetaPuntaje1.text = this.puntaje.ToString();

    }

    public void PuntajeLadoB()
    {
        puntaje++;
    }

}
