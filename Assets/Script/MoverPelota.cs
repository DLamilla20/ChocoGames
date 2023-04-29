using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverPelota : MonoBehaviour
{
    public float velocidadMovimiento;
    public float velocidadExtraPorGolpe;
    public float velocidadExtraMaxima;
    public MovimientoJugador1 j1;
    public MovimientoJugador2 j2;

    int contadorGolpes = 0;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(this.IniciarPelota());
    }

    public IEnumerator IniciarPelota(bool comienzaJugador1 = true)
    {
        this.PosicionarPelota(comienzaJugador1);

        this.contadorGolpes = 0;

        yield return new WaitForSeconds(2);

        if (comienzaJugador1)
        {
            this.MovimientoPelota(new Vector2(1, 0));
        }
        else
        {
            this.MovimientoPelota(new Vector2(-1, 0));
        }
    }

    void PosicionarPelota(bool comienzaJugador1)
    {
        this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);

        if (comienzaJugador1)
        {
            this.gameObject.transform.localPosition = new Vector3(-4, 5, 0);
            j1.gameObject.transform.localPosition = new Vector3(-5, 2, 64);
            j2.gameObject.transform.localPosition = new Vector3(5, 2, 64);
        }
        else
        {
            this.gameObject.transform.localPosition = new Vector3(4, 5, 0);
            j1.gameObject.transform.localPosition = new Vector3(-5, 2, 64);
            j2.gameObject.transform.localPosition = new Vector3(5, 2, 64);
        }
    }

    public void MovimientoPelota(Vector2 dir)
    {
        dir = dir.normalized;
        float velocidad = this.velocidadMovimiento + this.contadorGolpes * velocidadExtraPorGolpe;
        Rigidbody2D rb = this.gameObject.GetComponent<Rigidbody2D>();

        rb.velocity = dir * velocidad;
    }

    public void AumentarContadorGolpes()
    {
        if (this.contadorGolpes * this.velocidadExtraPorGolpe <= this.velocidadExtraMaxima)
        {
            this.contadorGolpes++;
        }
    }
}
