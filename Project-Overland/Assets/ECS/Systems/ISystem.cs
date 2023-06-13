namespace ECS.Systems {
    public interface ISystem
    {
        void OnCreate() { }
        void OnDestroy() { }
        void OnUpdate() { }
    }
}