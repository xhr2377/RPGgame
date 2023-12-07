using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayeridleState : PlayerGroundedState
{
    public PlayeridleState(Player _player, PlayerStateMachine _stateMashine, string _animBoolName) : base(_player, _stateMashine, _animBoolName)
    {
    }

    public override void Enter()
    {
        base.Enter();
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void Update()
    {
        base.Update();

        if (xInput != 0)
            stateMashine.ChangeState(player.moveState);

    }
}
