using Unity.Entities;
using Unity.Mathematics;
using Unity.Physics;
using Unity.Transforms;
using UnityEngine;

// Physics component to define the physics properties of an entity
public struct Physic : IComponentData
{
    public float Mass;
    public float3 Velocity;
}