using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisabledObject : MonoBehaviour
{
    public GameObject objectGame;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Disabled());
    }

    public IEnumerator Disabled()
    {
        yield return new WaitForSeconds(4);
        objectGame.SetActive(false);
    }
}
