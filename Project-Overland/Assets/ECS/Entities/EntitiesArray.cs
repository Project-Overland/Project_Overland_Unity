using Unity.Collections;
using Unity.Entities;
using UnityEngine;

public class EntitiesArray : MonoBehaviour
{
    private EntityManager entityManager;
    private NativeArray<Entity> entities;

    private void Start()
    {
        entityManager = World.DefaultGameObjectInjectionWorld.EntityManager;

        // Create an array of entities
        entities = new NativeArray<Entity>(3, Allocator.Persistent);

        // Create entities and store them in the array
        for (int i = 0; i < entities.Length; i++)
        {
            entities[i] = entityManager.CreateEntity();
            entityManager.AddComponentData(entities[i], new PositionComponent { Value = new Vector3(i, 0, 0) });
        }

        // Access and modify entity data in the array
        for (int i = 0; i < entities.Length; i++)
        {
            PositionComponent position = entityManager.GetComponentData<PositionComponent>(entities[i]);
            position.Value += new Unity.Mathematics.float3(1, 0, 0);
            entityManager.SetComponentData(entities[i], position);
        }
    }

    private void OnDestroy()
    {
        // Dispose of the native array when no longer needed
        entities.Dispose();
    }
}
