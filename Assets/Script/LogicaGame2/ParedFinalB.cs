using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ParedFinalB : MonoBehaviour
{
    public GameObject ganador;
    public Animator anim;
    public GameObject jugador1;
    public GameObject jugador2;

    private void Start()
    {
        this.ganador.gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Letra1B")
        {
            this.ganador.gameObject.SetActive(true);
            //TextMeshProUGUI gn = this.ganador.GetComponent<TextMeshProUGUI>();
            //gn.text = "WINNER PLAYER 1!";
            jugador2.gameObject.SetActive(false);
            jugador1.gameObject.transform.localPosition = new Vector3(6.21f, 0, 64);
            StartCoroutine(this.CambiarEscena());
        }
    }

    public IEnumerator CambiarEscena()
    {
        
        yield return new WaitForSeconds(1);
        anim.SetTrigger("Entrada");
        SceneManager.LoadScene(4);
    }

}
