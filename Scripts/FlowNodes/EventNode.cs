﻿using XNode;

namespace FlowNodes
{
    public abstract class EventNode : MonoNode {
        [Output] public Flow FlowOutput;

        public void TriggerFlow() {
            FlowUtils.TriggerFlow(Outputs, nameof(FlowNode.FlowOutput));
        }
    }
}
