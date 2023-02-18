using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JP
{
    [CreateAssetMenu(fileName = "StatData", menuName = "ScriptableObject/StatData", order = int.MaxValue)]
    public class StatData : ScriptableObject
    {
        [SerializeField] float HP;
        [SerializeField] float MP;
        [SerializeField] float STR;
        [SerializeField] float INT;
        [SerializeField] float AGI;

        public float GetHP { get { return HP; } }
        public float GetMP { get { return MP; } }
        public float GetSTR { get { return STR; } }
        public float GetINT { get { return INT; } }
        public float GetAGI { get { return AGI; } }
    }
}
