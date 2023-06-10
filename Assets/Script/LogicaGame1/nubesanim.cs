using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nubesanim : MonoBehaviour
{
   
    public float speed;
    public Rigidbody2D rd; 

    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       rd.velocity = new Vector2(-1, 0);
        StartCoroutine(Cargar());

    }
    public IEnumerator Cargar()
    {
        
        yield return new WaitForSeconds(65);
        Destroy(this.gameObject);
    }
}
