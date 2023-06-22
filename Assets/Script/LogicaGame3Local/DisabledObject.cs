using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisabledObject : MonoBehaviour
{
    public GameObject objectGame;
    public GameObject objectGame1;
    public GameObject objectGame2;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Disabled());
    }

    public IEnumerator Disabled()
    {
        yield return new WaitForSeconds(3);
        objectGame.SetActive(false);
        objectGame1.SetActive(false);
        objectGame2.SetActive(false);
    }
}
