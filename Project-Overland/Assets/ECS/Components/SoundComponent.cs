using Unity.Entities;
using Unity.Mathematics;
using Unity.Physics;
using Unity.Transforms;
using UnityEngine;

// Sound component to represent sound properties of an entity
public struct Sound : IComponentData
{
    public AudioClip Clip;
    public float Volume;
}