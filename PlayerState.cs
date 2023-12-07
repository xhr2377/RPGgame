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
    //ͨ������һ����Ҷ���һ��״̬�������һ����������ֵ��������ʼ����Щ�ֶ�

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
