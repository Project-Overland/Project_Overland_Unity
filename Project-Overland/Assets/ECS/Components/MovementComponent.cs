using Unity.Entities;
using Unity.Mathematics;

// MovementComponent definition
public struct MovementComponent : IComponentData
{
    public float3 Velocity;
    public float Speed;
}
