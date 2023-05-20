using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SeleccionarNivel : MonoBehaviour
{
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    public void CargarNivel(int nivel)
    {
        StartCoroutine(Cargar(nivel));
    }

    public IEnumerator Cargar(int sceneIndex)
    {
        anim.SetTrigger("Entrada");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(sceneIndex);
    }

    public void CargarRestart()
    {
        StartCoroutine(CargarReinicio());
    }

    public IEnumerator CargarReinicio()
    {
        ControladorEscena.Instace.IdEscena();
        anim.SetTrigger("Entrada");
        yield return new WaitForSeconds(1);
        //SceneManager.LoadScene(sceneIndex);
    }
}
