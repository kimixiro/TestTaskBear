using System;
using UnityEngine;


//in the full version of my simple AI asset, everything will be implemented normally.
public class BotAI : MonoBehaviour
{
    readonly StateMachine stateMachine = new StateMachine();

    private bool switcBool;

    public int lastPointIndex;
    
    void Start()
    {
        stateMachine.ChangeState(new IdleState(this));
    }
 
    void Update()
    {
        stateMachine.Update();
    }

    public void Move(Vector3 target,int pointIndex)
    {
        lastPointIndex = pointIndex;
        stateMachine.ChangeState(new MoveState(this,target));
    }

    public void IdleState()
    {
          stateMachine.ChangeState(new IdleState(this));
    }
}