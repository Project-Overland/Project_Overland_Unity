using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

public partial class RotationSystem : SystemBase
{
    protected override void OnUpdate()
    {
        Entities.ForEach((ref Rotation rotation, in RotationSpeed rotationSpeed) =>
        {
            // Rotate the entity based on the rotation speed
            float rotationAngle = rotationSpeed.Value * SystemAPI.Time.DeltaTime;
            quaternion rotationDelta = quaternion.RotateY(rotationAngle);
            rotation.Value = math.mul(rotation.Value, rotationDelta);
        }).Schedule();
    }
}
