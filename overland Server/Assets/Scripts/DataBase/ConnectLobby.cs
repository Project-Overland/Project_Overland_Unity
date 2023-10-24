using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class DataBaseManager
{
    public void ConnectLobby(string username, string lobbyName)
    {
        // Create the user data
        UserConnectData connectData = new UserConnectData
        {
            username = username,
            lobbyName = lobbyName
        };

        // Convert the user data to JSON
        string json = JsonUtility.ToJson(connectData);

        // Show the JSON in the console
        Debug.Log(json);

        // Start the coroutine to login the user
        StartCoroutine(SendRequest(json, "connectLobby"));
    }
}
