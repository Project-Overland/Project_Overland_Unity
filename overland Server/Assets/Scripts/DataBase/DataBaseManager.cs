using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.UI;
using UnityEngine;
using UnityEngine.Networking;

public partial class DataBaseManager : MonoBehaviour
{
    [SerializeField] private string ip;
    [SerializeField] private ushort port;

    private void Start()
    {
    }

    // Send a request to the database
    public IEnumerator SendRequest(string data, string requestType)
    {
        // Create the request
        UnityWebRequest request = new UnityWebRequest($"http://{ip}:{port}/{requestType}", "POST");

        // Show the JSON in the console
        Debug.Log(data);

        // Set the request body
        byte[] bodyRaw = System.Text.Encoding.UTF8.GetBytes(data);
        request.uploadHandler = new UploadHandlerRaw(bodyRaw);
        request.downloadHandler = new DownloadHandlerBuffer();

        // Set the request headers
        request.SetRequestHeader("Content-Type", "application/json");

        // Send the request
        yield return request.SendWebRequest();

        // Check for errors
        if (request.isNetworkError || request.isHttpError)
        {
            Debug.LogError(request.error);
        }
        else
        {
            // Get the response
            string response = request.downloadHandler.text;
            Debug.Log(response);
        }

        // Dispose of the request
        request.Dispose();

    }

    // Response converter
    public static T ConvertResponse<T>(string response)
    {
        // Convert the response to the specified type
        return JsonUtility.FromJson<T>(response);
    }
    
}
