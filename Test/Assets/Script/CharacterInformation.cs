using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JP
{
    public class CharacterInformation : MonoBehaviour
    {
        [SerializeField] StatData staticData;

        float runTime_HP;
        float runTime_MP;
        float runTime_STR;
        float runTime_INT;
        float runTime_AGI;

        public float RunTimeHP { get { return runTime_HP; } set { runTime_HP = value; } }
        public float RunTimeMP { get { return runTime_MP; } set { runTime_MP = value; } }
        public float RunTimeSTR { get { return runTime_STR; } set { runTime_STR = value; } }
        public float RunTimeINT { get { return runTime_INT; } set { runTime_INT = value; } }
        public float RunTimeAGI { get { return runTime_AGI; } set { runTime_AGI = value; } }

        private void Start()
        {
            runTime_HP = staticData.GetHP;
            runTime_MP = staticData.GetMP;
            runTime_STR = staticData.GetSTR;
            runTime_INT = staticData.GetINT;
            runTime_AGI = staticData.GetAGI;
        }
    }
}
