using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador1B : MonoBehaviour
{
    public GameObject[] Gene1B;
    private float tiempoEntreLetras;
    private float comienzoDeTiempo; //1.5 1.1 0.7
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (tiempoEntreLetras <= 0)
        {
            int random = Random.Range(0, Gene1B.Length);
            Instantiate(Gene1B[random],this.transform.position,Quaternion.identity);

            //StartCoroutine(Tiempo());
            comienzoDeTiempo = 0.7f;
            tiempoEntreLetras = comienzoDeTiempo;
        }
        else
        {
            tiempoEntreLetras -= Time.deltaTime;
        }
    }

    //public IEnumerator Tiempo()
    //{
    //    comienzoDeTiempo = 1.5f;
        
    //    print("Tiempo 1.5f");

    //    yield return new WaitForSeconds(10);
    //    comienzoDeTiempo = 1.1f;
    //    print("Tiempo 1.1f");

    //    yield return new WaitForSeconds(10);
       
    //    print("Tiempo 0.7f");
    //}
}
