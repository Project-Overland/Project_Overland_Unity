using Unity.Entities;
using Unity.Mathematics;
using Unity.Physics;
using Unity.Transforms;
using UnityEngine;

public struct InputComponent : IComponentData
{
    public float Horizontal;
    public float Vertical;
    public float Jump;
    public float Fire;
    // Add more input properties as needed
}