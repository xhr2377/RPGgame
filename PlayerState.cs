using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState 
{
    protected PlayerStateMachine stateMashine;
    protected Player player;

    protected Rigidbody2D rb;


    protected float xInput;
    private string animBoolName;
    protected float stateTimer;


    public PlayerState(Player _player, PlayerStateMachine _stateMashine, string _animBoolName)
    {
        this.player = _player;
        this.stateMashine = _stateMashine;
        this.animBoolName = _animBoolName;
    }
    //通过传入一个玩家对象、一个状态机对象和一个动画布尔值名称来初始化这些字段

    public virtual void Enter()
    {

        player.anim.SetBool(animBoolName, true);
        rb = player.rb;
    }

    public virtual void Update()
    {
        stateTimer -= Time.deltaTime;
        xInput = Input.GetAxisRaw("Horizontal");

        player.anim.SetFloat("yVelocity",rb.velocity.y);
    }

    public virtual void Exit()
    {
        player.anim.SetBool(animBoolName, false);
    }



}
