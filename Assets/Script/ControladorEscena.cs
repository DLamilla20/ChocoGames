using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorEscena : MonoBehaviour
{
    public static ControladorEscena Instace;

    //[SerializeField] private int idEscena;

    private void Awake()
    {
        if (ControladorEscena.Instace == null)
        {
            ControladorEscena.Instace = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void IdEscena()
    {
        int idEscena = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(idEscena);
        print(idEscena);
    }
}
