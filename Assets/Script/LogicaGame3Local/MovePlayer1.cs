using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MovePlayer1 : MonoBehaviour
{
    public float speed;
    private float x;
    private float y;
    float resetSpeed = 8f;
    public float dashSpeed;
    public float dashTime;
    private Rigidbody2D rb;
    public GameObject gameOver;
    private int cont;
    public TextMeshProUGUI winnerText;
    public GameObject player2;
    public ParticleSystem particles;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxisRaw("Horizontal4");
        y = Input.GetAxisRaw("Vertical1");

        rb.velocity = new Vector2(x * speed, y * speed);
        if ((x != 0) || (y != 0))
        {
            anim.SetBool("estaMoviendose", true);
        }
        else
        {
            anim.SetBool("estaMoviendose", false);
        }

        if (x != 0 && cont != 1)
        {
            VoltearJugador(x);
        }
        

        if (Input.GetKeyDown(KeyCode.Space) && (x != 0 || y != 0))
        {
            particles.Play();
            StartCoroutine(Dash());
        }
        if (cont == 1)
        {
            rb.velocity = Vector2.zero;
            player2.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }
    }

    public IEnumerator Dash()
    {
        speed = dashSpeed;
        yield return new WaitForSeconds(dashTime);
        speed = resetSpeed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Pelota")
        {
            gameOver.SetActive(true);
            cont = 1;
            winnerText.text = "CHIPO";
        }

    }

    private void VoltearJugador(float dirJugador)
    {
        Vector3 escalaJugador = transform.localScale;
        if (dirJugador < 0)
        {
            escalaJugador.x = Mathf.Abs(escalaJugador.x) * -1;
        }
        else if (dirJugador > 0)
        {
            escalaJugador.x = Mathf.Abs(escalaJugador.x);
        }

        transform.localScale = escalaJugador;

    }
}
