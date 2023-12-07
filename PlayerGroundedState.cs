using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerGroundedState : PlayerState //继承玩家状态
{
    public PlayerGroundedState(Player _player, PlayerStateMachine _stateMashine, string _animBoolName) : base(_player, _stateMashine, _animBoolName)
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

        if(!player.IsGroundDetected())
            stateMashine.ChangeState(player.airState);


        if (Input.GetKeyDown(KeyCode.Space) && player.IsGroundDetected()) 
            stateMashine.ChangeState(player.jumpState); //各种状态都要先在player.cs声明才能调用
    }
}
