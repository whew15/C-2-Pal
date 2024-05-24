using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.TextCore.Text;

//행동 쓸 때마다 상속
public abstract class BaseState : MonoBehaviour
{
    protected Character _character;

    protected BaseState(Character character)
    {
        _character = character;
    }

    public abstract void OnStateEnter();
    public abstract void OnStateUpdate();
    public abstract void OnStateExit();
}
