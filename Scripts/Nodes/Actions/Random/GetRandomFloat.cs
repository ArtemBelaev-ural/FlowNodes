﻿using UnityEngine;
using XNode;

namespace FlowNodes
{
    [CreateNodeMenu("Random/" + nameof(GetRandomFloat), "Random", "Float")]
    public class GetRandomFloat : MonoNode {
        [Input] public float Min;
        [Input] public float Max;
        [Output] public float Result;

        // Return the correct value of an output port when requested
        public override object GetValue(NodePort port) 
        {
            if(port.fieldName == nameof(Result)) 
            {
                var min = GetInputValue(nameof(Min), Min);
                var max = GetInputValue(nameof(Max), Max);
                Result = UnityEngine.Random.Range(min, max);
                return Result;
            }
            return null; // Replace this
        }
    }
}
