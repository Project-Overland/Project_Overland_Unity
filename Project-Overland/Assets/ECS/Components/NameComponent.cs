using Unity.Entities;
using Unity.Mathematics;
using Unity.Physics;
using Unity.Transforms;
using UnityEngine;

// Name component to store the name of an entity
public struct Name : IComponentData
{
    public string Value;
}