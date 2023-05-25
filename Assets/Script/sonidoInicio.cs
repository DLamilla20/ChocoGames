using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonidoInicio : MonoBehaviour
{
    public AudioSource sonido;
    private AudioClip sonido1;
    private void Start()
    {
        sonido.Play();
    }
    public void EjecutarSonido(AudioClip a)
    {
        sonido.PlayOneShot(a);
    }
}
