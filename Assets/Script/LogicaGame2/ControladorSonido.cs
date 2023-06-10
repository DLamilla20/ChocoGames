using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorSonido : MonoBehaviour
{
    public static ControladorSonido Instance;

    private AudioSource audioMusica;

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

        audioMusica = GetComponent<AudioSource>();
    }

    public void EjecutarSonido(AudioClip sonido) 
    {
        audioMusica.PlayOneShot(sonido);
    }
}
