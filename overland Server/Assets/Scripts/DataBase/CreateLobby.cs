using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class DataBaseManager
{
    public void CreateLobby(string lobbyName, string lobbyDescription, string lobbyPic)
    {
        // Create the user data
        LobbyData lobbyData = new LobbyData
        {
            lobbyName = lobbyName,
            lobbyDescription = lobbyDescription,
            lobbyPic = lobbyPic
        };

        // Convert the user data to JSON
        string json = JsonUtility.ToJson(lobbyData);

        // Show the JSON in the console
        Debug.Log(json);

        // Start the coroutine to register the user
        StartCoroutine(SendRequest(json, "createLobby"));
    }
}
