using Unity.Entities;
using UnityEngine;
using Unity.Mathematics;
using UnityEngine.InputSystem;

public partial struct InputSystem : ISystem
{
    public void Update()
    {
        // Get input from Unity's Input class
        float horizontal = UnityEngine.Input.GetAxis("Horizontal");
        float vertical = UnityEngine.Input.GetAxis("Vertical");
        float jump = UnityEngine.Input.GetAxis("Jump");
        float fire = UnityEngine.Input.GetAxis("Fire1");

        // Create a new Input component
        // InputComponent input = new InputComponent
        // {
        //     Horizontal = horizontal,
        //     Vertical = vertical,
        //     Jump = jump,
        //     Fire = fire
        // };

        // Add the Input component to the player entity
        // EntityManager.SetComponentData(GameManager.playerEntity, input);
    }
}
