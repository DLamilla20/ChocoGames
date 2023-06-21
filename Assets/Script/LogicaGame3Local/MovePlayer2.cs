using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MovePlayer2 : MonoBehaviour
{
    public float speed;
    private float x;
    private float y;
    float resetSpeed = 5.5f;
    public float dashSpeed;
    public float dashTime;
    private Rigidbody2D rb;
    public GameObject gameOver;
    private int cont;
    public TextMeshProUGUI winnerText;
    public GameObject player1;
    public ParticleSystem particles;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxisRaw("Horizontal5");
        y = Input.GetAxisRaw("Vertical");

        rb.velocity = new Vector2(x * speed, y * speed);

        if (Input.GetKeyDown(KeyCode.Space) && (x != 0 || y != 0))
        {
            particles.Play();
            StartCoroutine(Dash());
        }
        if (cont == 1)
        {
            rb.velocity = Vector2.zero;
            player1.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
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
            winnerText.text = "CHOPO";
        }

    }
}
