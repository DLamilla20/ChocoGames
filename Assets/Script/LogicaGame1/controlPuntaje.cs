using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class controlPuntaje : MonoBehaviour
{
    private int puntajeJugador1;
    private int puntajeJugador2;

    public GameObject textoPuntaje1;
    public GameObject textoPuntaje2;
    public GameObject ganador;
    public GameObject pelota;
    public GameObject red;
    public GameObject Jugador1;
    public GameObject Jugador2;
    public Animator anim;

    public int metaParaGanar;
    private void Start()
    {
        this.ganador.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (this.puntajeJugador1 >= this.metaParaGanar)
        {
            this.ganador.gameObject.SetActive(true);
            //TextMeshProUGUI gn = this.ganador.GetComponent<TextMeshProUGUI>();
            //gn.text = "WINNER PLAYER 1!";
            this.pelota.gameObject.SetActive(false);
            this.red.gameObject.SetActive(false);
            this.Jugador2.gameObject.SetActive(false);
            Jugador1.gameObject.transform.localPosition = new Vector3(0, 2, 64);
            //StartCoroutine(this.CambiarEscena());
        }
        else if (this.puntajeJugador2 >= this.metaParaGanar)
        {
            this.ganador.gameObject.SetActive(true);
            //TextMeshProUGUI gn = this.ganador.GetComponent<TextMeshProUGUI>();
            //gn.text = "WINNER PLAYER 2!";
            this.pelota.gameObject.SetActive(false);
            this.red.gameObject.SetActive(false);
            this.Jugador1.gameObject.SetActive(false);
            Jugador2.gameObject.transform.localPosition = new Vector3(0, 2, 64);
            //StartCoroutine(this.CambiarEscena());
        }
    }

    private void FixedUpdate()
    {
        TextMeshProUGUI etiquetaPuntaje1 = this.textoPuntaje1.GetComponent<TextMeshProUGUI>();
        etiquetaPuntaje1.text = this.puntajeJugador1.ToString();

        TextMeshProUGUI etiquetaPuntaje2 = this.textoPuntaje2.GetComponent<TextMeshProUGUI>();
        etiquetaPuntaje2.text = this.puntajeJugador2.ToString();
    }

    public void GolJugador1()
    {
        this.puntajeJugador1++;
    }

    public void GolJugador2()
    {
        this.puntajeJugador2++;
    }
    
    public IEnumerator CambiarEscena()
    {
        anim.SetTrigger("Entrada");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(3);
    }
}
