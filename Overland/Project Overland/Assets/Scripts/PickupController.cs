using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupController : MonoBehaviour
{
    [SerializeField] Transform holdArea;
    private MouseLook lookScript;
    private GameObject heldObj;
    private Rigidbody heldObjRB;
    [SerializeField] private float pickupRange = 5.0f;
    [SerializeField] private float pickupForce = 150.0f;
    [SerializeField] private float throwMultiplier = 100.0f;
    [SerializeField] private float rotationSpeed = 5.0f;
    private bool rotating = false;

    private void Start()
    {
        lookScript = GetComponent<MouseLook>();
    }
    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(1) && heldObj != null)
        {
            rotating = !rotating;
        }
        if (rotating)
        {
            if (heldObj == null) {
                rotating = false;
                lookScript.enabled = true;
            }
            else
               lookScript.enabled = false;
        }
        else
        {
            lookScript.enabled = true;
        }

        if (Input.GetKey("q") && heldObj != null)
        {
            throwMultiplier += 100f * Time.deltaTime;
            throwMultiplier = Mathf.Clamp(throwMultiplier, 100, 800);
        }
        if (Input.GetKeyUp("q") && heldObj != null)
        {
            heldObjRB.AddForce(gameObject.transform.forward * throwMultiplier);
            DropObject();
        }
        if (Input.GetMouseButtonDown(0))
        {
            if (heldObj == null)
            {
                RaycastHit hit;
                if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, pickupRange))
                {
                    PickupObject(hit.transform.gameObject);
                }
            }
            else
            {
                DropObject();
            }
        }
        if (heldObj != null)
        {
            MoveObject();
            if (rotating)
            {
                float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime;
                float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime;
                Vector3 rotation = new Vector3(mouseY, -mouseX);
                heldObj.transform.Rotate(rotation * rotationSpeed, Space.World);
            }
        }
    }
    void MoveObject()
    {
        if (Vector3.Distance(heldObj.transform.position, holdArea.position) > 0.1f)
        {
            Vector3 moveDirection = holdArea.position - heldObj.transform.position;
            heldObjRB.AddForce(moveDirection * pickupForce);
        }
    }
    void PickupObject(GameObject pickObj)
    {
        if (pickObj.GetComponent<Rigidbody>())
        {
            heldObjRB = pickObj.GetComponent<Rigidbody>();
            heldObjRB.useGravity = false;
            heldObjRB.drag = 10;
            heldObjRB.constraints = RigidbodyConstraints.FreezeRotation;
            heldObjRB.transform.parent = holdArea;
            heldObj = pickObj;
        }
    }
    void DropObject()
    {
        heldObjRB.useGravity = true;
        heldObjRB.drag = 1;
        heldObjRB.constraints = RigidbodyConstraints.None;
        heldObjRB.transform.parent = null;
        heldObj = null;
        throwMultiplier = 100f;
    }
}