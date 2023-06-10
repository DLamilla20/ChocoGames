using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ParedFinalA : MonoBehaviour
{
    public GameObject ganador;
    public Animator anim;

    private void Start()
    {
        this.ganador.gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Letra1A")
        {
            this.ganador.gameObject.SetActive(true);
            TextMeshProUGUI gn = this.ganador.GetComponent<TextMeshProUGUI>();
            gn.text = "WINNER PLAYER 2!";
            StartCoroutine(this.CambiarEscena());
        }
    }

    public IEnumerator CambiarEscena()
    {
        
        yield return new WaitForSeconds(1);
        anim.SetTrigger("Entrada");
        SceneManager.LoadScene(6);
    }
}
