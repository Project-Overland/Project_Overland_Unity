using Unity.Entities;
using Unity.Mathematics;
using Unity.Physics;
using Unity.Transforms;
using UnityEngine;

// Description component to store a description of an entity
public struct DescriptionComponent : IComponentData
{
    public string Value;
}