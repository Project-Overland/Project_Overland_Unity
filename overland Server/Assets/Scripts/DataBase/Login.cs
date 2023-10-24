using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class DataBaseManager
{
    public void LoginUser(string username, string password)
    {
        // Create the user data
        UserData userData = new UserData
        {
            username = username,
            password = password
        };

        // Convert the user data to JSON
        string json = JsonUtility.ToJson(userData);

        // Show the JSON in the console
        Debug.Log(json);

        // Start the coroutine to login the user
        StartCoroutine(SendRequest(json, "login"));
    }
}
