using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorBaile : MonoBehaviour
{
    public static ControladorBaile Instance;

    private Animator animator1;
    private Animator animator2;
    // Start is called before the first frame update
    private void Start()
    {
        animator1 = GameObject.Find("Jugador1").GetComponentInChildren<Animator>();
    }
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

        
    }

    public void Baile(int i) 
    {
        if (i == 1)
        {
            if (animator1 != null)
            {
                print("Hola1");
                string cArriba = "cArriba";
                animator1.SetBool(cArriba, true);
                StartCoroutine(Espera(cArriba));
            }
            
        }
        else if (i == 2)
        {
            if (animator1 != null)
            {
                print("Hola2");
                string cIzquierda = "cIzquierda";
                animator1.SetBool(cIzquierda, true);
                StartCoroutine(Espera(cIzquierda));
            }
        }
        else if (i == 3)
        {
            if (animator1 != null)
            {
                print("Hola3");
                string cAbajo = "cAbajo";
                animator1.SetBool(cAbajo, true);
                StartCoroutine(Espera(cAbajo));
            }
        }
        else if (i == 4)
        {
            if (animator1 != null)
            {
                print("Hola4");
                string cDerecha = "cDerecha";
                animator1.SetBool(cDerecha, true);
                StartCoroutine(Espera(cDerecha));
            }
        }
    }

    public IEnumerator Espera(string tipo) 
    {
        yield return new WaitForSeconds(1.3f);
        animator1.SetBool(tipo, false);
    }
}
