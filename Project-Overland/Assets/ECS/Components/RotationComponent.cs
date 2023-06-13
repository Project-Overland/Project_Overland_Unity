using Unity.Entities;
using Unity.Mathematics;
using Unity.Physics;
using Unity.Transforms;
using UnityEngine;

// Rotation component to store the rotation of an entity
public struct Rotation : IComponentData
{
    public quaternion Value;
}