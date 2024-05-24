using System;
using UnityEngine;
using UnityEngine.XR;

public class FSM : MonoBehaviour
{
    private BaseState _baseState;
    public FSM(BaseState baseState)
    {
        _baseState = baseState;
        ChangeState(_baseState);
    }

    private void ChangeState(BaseState baseState)
    {
        
    }
}
