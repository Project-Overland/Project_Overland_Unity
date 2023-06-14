using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

public partial class MovementSystem : SystemBase
{
    protected override void OnUpdate()
    {
        float deltaTime = SystemAPI.Time.DeltaTime;

        Entities.ForEach((Entity entity, ref Translation translation, in Rotation rotation, in MovementComponent movement) =>
        {
            // Perform movement calculations based on the movement component data
            float3 moveVector = math.mul(rotation.Value, new float3(0f, 0f, movement.Speed)) * deltaTime;
            translation.Value += moveVector;
        }).Schedule();
    }
}
