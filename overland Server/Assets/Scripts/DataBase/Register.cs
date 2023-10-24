using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class DataBaseManager
{
    public void RegisterUser(string username, string password, string email)
    {
        // Create the user data
        UserData userData = new UserData
        {
            username = username,
            password = password,
            email = email
        };

        // Convert the user data to JSON
        string json = JsonUtility.ToJson(userData);

        // Show the JSON in the console
        Debug.Log(json);

        // Start the coroutine to register the user
        StartCoroutine(SendRequest(json, "register"));
    }
}
