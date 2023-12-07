using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine
{

    public PlayerState currentState {  get; private set; }


    public void Initialize(PlayerState _startState) //��idle��״̬����Player
    {
        currentState = _startState;
        currentState.Enter();
    }

    public void ChangeState(PlayerState _newState)
    {
        currentState.Exit();
        currentState = _newState;
        currentState.Enter(); //�ı䵱ǰ״̬
    }

}


