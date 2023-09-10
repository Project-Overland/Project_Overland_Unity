using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceScript : MonoBehaviour
{
    static Rigidbody rb;
    public static Vector3 diceVelocity;
    // add a public static int diceNumber
    public int diceNumber;
    // add a list of of game object for the dice sides where we can edit the position of the game objects
    public int diceSidesNumber;
    List<GameObject> diceSides;
    // add a mesh filter
    MeshFilter mf;
    bool isGrounded;

    // add a list of vectors for the dice sides
    // public List<Vector3> diceSidesVectors;
        

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        mf = GetComponent<MeshFilter>();
        isGrounded = true;
        diceSides = new List<GameObject>();
        for (int i = 1; i <= diceSidesNumber; i++) {
            diceSides.Add(GameObject.Find("Side" + (i)));
        }

    }

    // Update is called once per frame
    void Update()
    {
        diceVelocity = rb.velocity;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            RollDice();
        }

        // if velocity is 0, get the dice number
        if (diceVelocity.x == 0 && diceVelocity.y == 0 && diceVelocity.z == 0)
        {
            GetDiceNumber();
        }
        
    }

    void RollDice()
    {
        if (diceVelocity.x == 0 && diceVelocity.y == 0 && diceVelocity.z == 0)
        {
            isGrounded = false;
            float dirX = Random.Range(0, 500);
            float dirY = Random.Range(0, 500);
            float dirZ = Random.Range(0, 500);

			transform.position = new Vector3 (0, 2, 0);
			transform.rotation = Quaternion.identity;

            rb.AddForce(transform.up * 500);
            rb.AddTorque(dirX, dirY, dirZ);
            diceNumber = 0;
        }
    }

    void GetDiceNumber()
    {
        // get the dice sides with max y position
        GameObject topSide = diceSides[0];        
        
        // for each dice side collider in the list of dice sides colliders get the element on the top
        foreach (GameObject diceSide in diceSides) {
            // get the dice position
            Vector3 diceSidePos = diceSide.transform.position;
            // get the dice rotation
            // Quaternion diceSideRot = diceSide.transform.rotation;
            // log the dice side position
            // int diceSideIndex = diceSides.IndexOf(diceSide);

            // Debug.Log(" pos : " + diceSidePos + " rot : " + diceSideRot + " name : " + diceSide.name);
             
            // if the dice side is on the top with the greater y position
            if (diceSidePos.y > topSide.transform.position.y) {
                // set the top side to the dice side
                topSide = diceSide;
            }
        }
        // get value from name
        // diceNumber = int.Parse(diceSide.name);
        // get the value from the dice side name after the 4th character
        diceNumber = int.Parse(topSide.name.Substring(4));
        isGrounded = true;
    }
}
