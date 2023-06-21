using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;

public class SeleccionarNivel1 : MonoBehaviour
{
    private Animator anim;
    
    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    public void CargarNivel(int nivel)
    {
        PhotonNetwork.Disconnect();
        StartCoroutine(Cargar(nivel));
    }

    public IEnumerator Cargar(int sceneIndex)
    {
        anim.SetTrigger("Entrada");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(sceneIndex);
    }

}
