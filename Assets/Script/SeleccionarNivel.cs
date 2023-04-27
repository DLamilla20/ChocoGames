using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SeleccionarNivel : MonoBehaviour
{
    
    public void CargarNivel(int nivel)
    {
        SceneManager.LoadScene(nivel);
    }

}
