using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNode;

namespace BoGD
{
    /// <summary>
    /// ���������� ����������� ������ ��������� �� ������� � ��������� ��� ���������
    /// </summary>
    [AddComponentMenu("Math/FloatCurve")]
    [CreateNodeMenu("Math/FloatCurve")]
    public class FloatCurveParameter : MonoNode
    {
        [Input]
        public float            input = 0.0f;
        [Output]
        public float            output;

        [SerializeField]
        private AnimationCurve  curve = new AnimationCurve();


        public override object GetValue(NodePort port)
        {
            if (port.fieldName == nameof(output))
            {
                input = GetInputValue(nameof(input), input);
                output = curve.Evaluate(input);
                return output;
            }
            else return null;
        }
    }
}
