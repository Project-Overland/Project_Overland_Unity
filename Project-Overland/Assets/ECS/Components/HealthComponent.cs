using Unity.Entities;
using Unity.Mathematics;
using Unity.Physics;
using Unity.Transforms;
using UnityEngine;

// Health component to track the health of an entity
public struct HealthComponent : IComponentData
{
    public int CurrentHealth;
    public int MaxHealth;
}