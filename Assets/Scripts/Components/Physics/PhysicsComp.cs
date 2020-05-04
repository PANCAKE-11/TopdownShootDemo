using System.Collections.Generic;
using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace Components.Physics
{
    [Physics]
    [Unique]
    public sealed class PhysicsComp : IComponent
    {
        public List<CollisionInfo> CollisionInfos;
    }
}
