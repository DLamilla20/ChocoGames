using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using TMPro;

public class SpawnPlayer : MonoBehaviour
{
    public TextMeshProUGUI roomName;
    public GameObject[] player;
    public Transform[] spawnPoints;
    // Start is called before the first frame update
    void Start()
    {
        

        if (PhotonNetwork.CurrentRoom.PlayerCount == 1)
        {

            PhotonNetwork.Instantiate(player[0].name, spawnPoints[0].transform.position, Quaternion.identity);  //Chipo
        }
        else
        {
            PhotonNetwork.Instantiate(player[1].name, spawnPoints[1].transform.position, Quaternion.identity);  //Chopo
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (PhotonNetwork.InRoom)
        {
            string name = PhotonNetwork.CurrentRoom.Name;
            roomName.text = name;
        }
    }
}
