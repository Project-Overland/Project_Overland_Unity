using Unity.Entities;
using Unity.Mathematics;
using Unity.Physics;

// Define the PhysicsVelocity component
public struct PhysicsVelocity : IComponentData
{
    public float3 Linear;
    public float3 Angular;
}
