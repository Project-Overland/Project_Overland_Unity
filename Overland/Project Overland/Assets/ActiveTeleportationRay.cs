using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class ActiveTeleportationRay : MonoBehaviour
{
    public GameObject teleportRay;
    public InputActionProperty teleportAction;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        teleportRay.SetActive(teleportAction.action.ReadValue<float>() > 0.1f);
    }
}