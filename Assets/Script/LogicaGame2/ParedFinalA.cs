using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ParedFinalA : MonoBehaviour
{
        
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Letra1A")
        {
            SceneManager.LoadScene(6);
        }
    }
}
