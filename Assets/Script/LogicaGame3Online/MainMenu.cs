using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Photon.Pun;
using Photon.Realtime;

public class MainMenu : MonoBehaviourPunCallbacks
{
    public TMP_InputField joinInput;
    public GameObject errorNick1;
    public GeneradorRoom gr;

    public void CreateRoom()
    {
        RoomOptions roomOptions = new RoomOptions();
        roomOptions.MaxPlayers = 2;
        PhotonNetwork.CreateRoom(gr.GenerarRoom(), roomOptions);
    }

    public void JoinRoom()
    {
        int joinInt = joinInput.text.Length;
        if (joinInt == 0)
        {
            errorNick1.SetActive(true);
            StartCoroutine(Espera());
        }
        else
        {
            PhotonNetwork.JoinRoom(joinInput.text.ToUpper());
        }

    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel(8);
    }

    public IEnumerator Espera()
    {
        yield return new WaitForSeconds(2);
        errorNick1.SetActive(false);
    }
}
