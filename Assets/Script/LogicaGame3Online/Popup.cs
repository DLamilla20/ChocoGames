using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Popup : MonoBehaviour
{
    PhotonView view;
    public GameObject gameOver;
    // Start is called before the first frame update
    void Start()
    {
        view = GetComponent<PhotonView>();
    }

    public void ShowMessage() 
    {
        view.RPC("ShowPopUp", RpcTarget.All);
    }

    [PunRPC]
    void ShowPopUp() 
    {
        gameOver.SetActive(true);
    }
}
