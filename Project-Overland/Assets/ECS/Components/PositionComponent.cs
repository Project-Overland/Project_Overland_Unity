using Unity.Entities;
using Unity.Mathematics;
using Unity.Physics;
using Unity.Transforms;
using UnityEngine;

// Position component to store the position of an entity
public struct PositionComponent : IComponentData
{
    public float3 Value;
}