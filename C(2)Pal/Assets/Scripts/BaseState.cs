using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.TextCore.Text;

//�ൿ �� ������ ���
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
