using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Queue<id, value> : MonoBehaviour
{
    struct TestStruct<TestID, TestValue> where TestID : IComparer<TestStruct<TestID, TestValue>>
    {
        public TestID UserID;
        public TestValue Speed;

    /*    public int CompareTo(TestStruct<id, value> other)
        {
            //return ;
        }*/
    }
}