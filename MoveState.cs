using UnityEngine;

public class MoveState  : IState
{
    private BotAI _owner;
 
    public MoveState(BotAI owner) { this._owner = owner; }
 
    public void Enter()
    {
        Debug.Log("entering test state");
    }
 
    public void Execute()
    {
        Debug.Log("updating test state");
    }
 
    public void Exit()
    {
        Debug.Log("exiting test state");
    }
}