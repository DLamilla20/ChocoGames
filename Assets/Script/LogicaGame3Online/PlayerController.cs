using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerController : MonoBehaviour
{
    public float speed;
    float resetSpeed = 5.5f;
    public float dashSpeed;
    public float dashTime;

    Rigidbody2D rb;
    PhotonView view;
    Transform cameraTransform;
    Popup popUpScrip;

    private float x;
    private float y;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        view = GetComponent<PhotonView>();
        cameraTransform = GetComponentInChildren<Camera>().transform;
        popUpScrip = FindObjectOfType<Popup>();

        if (!view.IsMine)
        {
            GetComponentInChildren<Camera>().enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (view.IsMine)
        {
            x = Input.GetAxisRaw("Horizontal3");
            y = Input.GetAxisRaw("Vertical");
            rb.velocity = new Vector2(x * speed, y * speed);

            if (Input.GetKeyDown(KeyCode.Space) && (x != 0 || y != 0))
            {
                StartCoroutine(Dash());
            }

            if ((x != 0) || (y != 0))
            {
                //anim.SetBool("isMoving", true);

            }
            else
            {
                //anim.SetBool("isMoving", false);
            }

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
        if (view.IsMine)
        {
            if (collision.tag == "Pelota")
            {
                
                popUpScrip.ShowMessage();
            }
        }

    }
}
