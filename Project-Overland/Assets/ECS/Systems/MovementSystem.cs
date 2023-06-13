using Unity.Entities;
using Unity.Transforms;
using Unity.Mathematics;
using UnityEngine;

public partial struct MovementSystem : ISystem
{
    public void OnUpdate()
    {
        float deltaTime = Time.deltaTime;

        Entities.ForEach((ref Translation translation, in PhysicsVelocity physicsVelocity) =>
        {
            // Update position based on velocity and deltaTime
            translation.Value += physicsVelocity.Linear * deltaTime;
        }).Schedule();
    }
}