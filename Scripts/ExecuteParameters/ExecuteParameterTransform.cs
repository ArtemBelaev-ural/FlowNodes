using UnityEngine;
using XNode;

namespace FlowNodes
{
    /// <summary>
    /// Возвращает Transform, переданный в метод XSoundNodeGraph.Play()
    /// </summary>
    [AddComponentMenu("FlowNode/Parameter/Transform", 1)]
    [CreateNodeMenu("arameter/Transform", 1)]
    public class ExecuteParameterTransform : ExecuteParameter<Transform>
    {
    }
}
