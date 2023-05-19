using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ParedFinalA : MonoBehaviour
{
    
    public int intentos = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Letra1A")
        {
            intentos++;
            if (intentos == 3)
            {
                //SceneManager.LoadScene(3);
            }
        }
    }
}
