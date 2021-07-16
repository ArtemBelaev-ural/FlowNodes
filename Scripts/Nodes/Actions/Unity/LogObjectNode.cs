using UnityEngine;
using XNode;

namespace BoGD {
    [CreateNodeMenu("Utils/"+nameof(LogObjectNode))]
    public class LogObjectNode : FlowNode 
    {
        [Input(typeConstraint: TypeConstraint.None)] public string inputAsObject;

        public override void ExecuteNode() 
        {
            object[] objects = GetPort(nameof(inputAsObject)).GetInputValues();
            foreach (object obj in objects)
            {
                Debug.Log(obj);
            }
        }

        public override object GetValue(NodePort port) {
            return null;
        }
    }
}
