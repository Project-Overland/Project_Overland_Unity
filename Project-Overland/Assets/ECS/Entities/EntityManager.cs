using Unity.Entities;
using UnityEngine;

public class CustomEntityManager
{
    private EntityManager entityManager;

    public CustomEntityManager()
    {
        entityManager = World.DefaultGameObjectInjectionWorld.EntityManager;
    }

    public Entity CreateEntity()
    {
        return entityManager.CreateEntity();
    }

    public void DestroyEntity(Entity entity)
    {
        entityManager.DestroyEntity(entity);
    }

    public void AddComponentData<T>(Entity entity, T componentData) where T : struct, IComponentData
    {
        entityManager.AddComponentData(entity, componentData);
    }

    public T GetComponentData<T>(Entity entity) where T : struct, IComponentData
    {
        return entityManager.GetComponentData<T>(entity);
    }

    public void SetComponentData<T>(Entity entity, T componentData) where T : struct, IComponentData
    {
        entityManager.SetComponentData(entity, componentData);
    }
}