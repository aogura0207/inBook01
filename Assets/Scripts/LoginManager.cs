using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;

public class LoginManager : MonoBehaviourPunCallbacks
{
    public static LoginManager instance;
    public string playerName;

    public TMP_InputField PlayerName_InputName;

    public void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    #region UI Callback Methods
    public void ConnectAnonemously()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    public void ConnectToPhotonServer()
    {
        if (PlayerName_InputName != null)
        {
            playerName = PlayerName_InputName.text;�@�@// bookWorld ����@homeScene�@�� Go Home�@�������A���O�C���V�[������Ȃ����߁AplayerName�ɕۑ�
            PhotonNetwork.NickName = PlayerName_InputName.text;
            PhotonNetwork.ConnectUsingSettings();
        }
    }

    #endregion



    #region Photon Callback Methods

    public override void OnConnected()
    {
        Debug.Log("OnConnected is called. The server is available!");
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("Connected to Master Server with player name: " + PhotonNetwork.NickName);
        PhotonNetwork.LoadLevel("HomeScene");
    }

    #endregion
}
