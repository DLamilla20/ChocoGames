using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorBaile : MonoBehaviour
{
    public static ControladorBaile Instance;

    private Animator animator;
    // Start is called before the first frame update
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        animator = GameObject.Find("Jugador1").GetComponentInChildren<Animator>();
    }

    public void Baile(int i) 
    {
        if (i == 1)
        {
            print("Hola1");
            string cArriba = "cArriba";
            animator.SetBool(cArriba, true);
            StartCoroutine(Espera(cArriba));
        }
        else if (i == 2)
        {
            print("Hola2");
            string cIzquierda = "cIzquierda";
            animator.SetBool(cIzquierda, true);
            StartCoroutine(Espera(cIzquierda));
        }
        else if (i == 3)
        {
            print("Hola3");
            string cAbajo = "cAbajo";
            animator.SetBool(cAbajo, true);
            StartCoroutine(Espera(cAbajo));
        }
        else if (i == 4)
        {
            print("Hola4");
            string cDerecha = "cDerecha";
            animator.SetBool(cDerecha, true);
            StartCoroutine(Espera(cDerecha));
        }
    }

    public IEnumerator Espera(string tipo) 
    {
        yield return new WaitForSeconds(1.3f);
        animator.SetBool(tipo, false);
    }
}
