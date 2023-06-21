using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class GeneradorRoom : MonoBehaviour
{
    public string nameRoom;
    public string GenerarRoom()
    {
        string letras = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        int random = 5;
        for (int i = 0; i < random; i++)
        {
            nameRoom += letras[Random.Range(0, letras.Length)];
        }
        return nameRoom;
    }
}
