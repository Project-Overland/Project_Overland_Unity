using Unity.Entities;
using Unity.Mathematics;
using Unity.Physics;
using Unity.Transforms;
using UnityEngine;

// State component to represent the state of an entity
public struct State : IComponentData
{
    public int Value;
}