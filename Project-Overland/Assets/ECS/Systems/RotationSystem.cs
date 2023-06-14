using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

public partial class RotationSystem : SystemBase
{
    protected override void OnUpdate()
    {
        Entities.ForEach((ref RotationComponent rotation, in RotationSpeedComponent rotationSpeed) =>
        {
            // Rotate the entity based on the rotation speed
            float rotationAngle = rotationSpeed.Value * SystemAPI.Time.DeltaTime;
            quaternion rotationDelta = quaternion.RotateY(rotationAngle);
            rotation.Value = math.mul(rotation.Value, rotationDelta);
        }).Schedule();
    }
}
