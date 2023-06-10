using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomNumero : MonoBehaviour
{
    public int x;
    private void Update()
    {
        x = Random.Range(0, 4);
    }
}
