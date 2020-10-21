using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState  : IState
{
    BotAI owner;
 
    public IdleState(BotAI owner) { this.owner = owner; }
 
    public void Enter()
    {
        Debug.Log("entering test state Idle");
    }
 
    public void Execute()
    {
        Debug.Log("updating test state Idle");
    }
 
    public void Exit()
    {
        Debug.Log("Exit test state Idle");
    }
}