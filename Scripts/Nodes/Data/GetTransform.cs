﻿using UnityEngine;
using XNode;

namespace Data.UnityNative {
    [CreateNodeMenu("GameObject/"+nameof(GetTransform))]
    [NodeWidth(150)]
    public class GetTransform : MonoNode 
    {
        [Input] public GameObject input;
        [Output] public Transform objectTransform;

        public override object GetValue(NodePort port) 
        {
            input = GetInputValue(nameof(input), input);
            if (input == null) 
            {
                return null;
            }

            if (port.fieldName == nameof(objectTransform)) 
            {
                return input.transform.position;
            }

            return null;
        }
    }
}