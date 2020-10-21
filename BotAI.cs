using System;
using UnityEngine;

enum StateEnum
{
    Idle,
    Walking
}

public class BotAI : MonoBehaviour
{
    readonly StateMachine stateMachine = new StateMachine();
    
    private StateEnum currentStateId;
   
    void Start()
    {
        switch(currentStateId){
            case StateEnum.Idle:
                stateMachine.ChangeState(new IdleState(this));
                break;
            case StateEnum.Walking:
                stateMachine.ChangeState(new MoveState(this));
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
        
    }
 
    void Update()
    {
        stateMachine.Update();
    }
}
