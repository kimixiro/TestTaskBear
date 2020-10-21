using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveState  : IState
{
    private readonly BotAI _owner;
    public const float Speed = 5f;
    public Vector3 target;
    public MoveState(BotAI owner,Vector3 targetPoint) { this._owner = owner;
        target = targetPoint;
    }
 
    public void Enter()
    {
        Debug.Log("entering test state Move");
    }
 
    public void Execute()
    {
        if (Vector3.Distance(_owner.transform.position, target) > 0.1f)
        {
            float step = Speed * Time.deltaTime;
            _owner.transform.position = Vector3.MoveTowards(_owner.transform.position, target, step);
        }
    }
 
    public void Exit()
    {
        Debug.Log("Exit test state Move");
    }
}
