﻿using UnityEngine;
using XNode;

namespace FlowNodes
{
    [ExecuteInEditMode]
    [CreateNodeMenu("Events/" + nameof(OnUpdate), "Update")]
    public class OnUpdate : EventNode
    {
        public int Milliseconds;
        private float _timestamp
        {
            get; set;
        }

        private void Update()
        {
            if (UnityEngine.Time.realtimeSinceStartup > _timestamp)
            {
                TriggerFlow();
                _timestamp = UnityEngine.Time.realtimeSinceStartup + Milliseconds * 0.001f;
            }
        }

        public override object GetValue(NodePort port)
        {
            return null;
        }
    }
}
