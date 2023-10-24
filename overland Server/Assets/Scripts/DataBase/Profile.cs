using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class DataBaseManager
{
    public void ProfileUser(string username, string description, string profilePic)
    {
        // Create the user data
        ProfileData userData = new ProfileData
        {
            username = username,
            description = description,
            profilePic = profilePic
        };

        // Convert the user data to JSON
        string json = JsonUtility.ToJson(userData);

        // Show the JSON in the console
        Debug.Log(json);

        // Start the coroutine to register the user
        StartCoroutine(SendRequest(json, "profile"));
    }
}
