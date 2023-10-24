using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UserData
{
    public string username;
    public string password;
    public string email;
}

[System.Serializable]

public class ProfileData
{
    public string username;
    public string description;
    public string profilePic;
}

[System.Serializable]

public class LobbyData
{
    public string lobbyName;
    public string lobbyDescription;
    public string lobbyPic;
}

[System.Serializable]

public class UserConnectData
{
    public string username;
    public string lobbyName;
}