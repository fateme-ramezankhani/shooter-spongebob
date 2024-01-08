using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class RoomManager : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("connecting....");
        PhotonNetwork.ConnectUsingSettings();
    }
    public override void OnConnectedToMaster(){
        base.OnConnectedToMaster();
        Debug.Log("connected to server!");
        PhotonNetwork.JoinLobby();
    }
    public override void OnJoinedLobby(){
        base.OnJoinedLobby();
        PhotonNetwork.JoinOrCreateRoom("test",null,null);
        Debug.Log("we're connected and in a room now!");
    }
}
