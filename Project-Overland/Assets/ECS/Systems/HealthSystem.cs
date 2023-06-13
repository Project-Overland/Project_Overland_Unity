using Unity.Entities;
using Unity.Collections;
using UnityEngine;

public partial struct HealthSystem : ISystem
{
    public void OnUpdate()
    {
        // Check health and perform actions
    }

    public void OnCreate()
    {
        // Initialize health-related resources or data
    }

    // No need to implement OnDestroy()
}
