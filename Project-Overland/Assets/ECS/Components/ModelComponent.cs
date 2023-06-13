using Unity.Entities;
using Unity.Mathematics;
using Unity.Physics;
using Unity.Transforms;
using UnityEngine;

// Model component to represent a 3D model attached to an entity
public struct Model : IComponentData
{
    public GameObject Value;
}