using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class GameOver : MonoBehaviour
{
    public GameObject restartButton;
    public GameObject waitingText;
    public GameObject leaveRoom;
    PhotonView view;

    // Start is called before the first frame update
    void Start()
    {
        view = GetComponent<PhotonView>();

        if (PhotonNetwork.IsMasterClient == false)
        {
            restartButton.SetActive(false);
            leaveRoom.SetActive(true);
            waitingText.SetActive(true);
        }
    }

    public void OnClickRestart() 
    {
        view.RPC("Restart", RpcTarget.All);
    }

    public void OnClickLeave()
    {
        view.RPC("Leave", RpcTarget.All);
    }

    [PunRPC]
    void Restart()
    {
        PhotonNetwork.LoadLevel(8); //Scena donde empieza el juego 3
    }

    [PunRPC]
    void Leave()
    {
        PhotonNetwork.LeaveRoom();
        PhotonNetwork.LoadLevel(7);
    }

}
