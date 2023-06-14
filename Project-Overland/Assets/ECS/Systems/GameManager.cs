using Unity.Entities;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private EntityManager entityManager;
    private Entity playerEntity;

    private void Start()
    {
        // Get the EntityManager
        entityManager = World.DefaultGameObjectInjectionWorld.EntityManager;

        // Initialize the game
        InitializeGame();
    }

    private void InitializeGame()
    {
        // Create the player entity
        playerEntity = CreatePlayerEntity();

        // Add necessary systems to the ECS world
        AddSystemsToWorld();

        // Start the game loop
        StartGameLoop();
    }

    private Entity CreatePlayerEntity()
    {
        // Create the player entity and add necessary components
        Entity entity = entityManager.CreateEntity();
        entityManager.AddComponentData(entity, new PlayerComponent());
        entityManager.AddComponentData(entity, new MovementComponent());

        // Return the player entity
        return entity;
    }

    private void AddSystemsToWorld()
    {
        // Add your systems to the ECS world
        World.DefaultGameObjectInjectionWorld.GetOrCreateSystem<InputSystem>();
        World.DefaultGameObjectInjectionWorld.GetOrCreateSystem<MovementSystem>();
    }

    private void StartGameLoop()
    {
        // Start any necessary game loop logic
    }
}
