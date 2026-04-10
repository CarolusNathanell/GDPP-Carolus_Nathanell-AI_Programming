using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RetreatState : BaseState
{
    public void EnterState(Enemy enemy)
    {
        enemy._animator.SetTrigger("RetreatState");
        Debug.Log("Start Retreating");
    }

    public void UpdateState(Enemy enemy)
    {
        if (enemy.Player != null)
        {
            enemy._navMeshAgent.destination = enemy.transform.position - enemy.Player.transform.position;
        }
    }

    public void ExitState(Enemy enemy)
    {
        Debug.Log("Stop Retreating");
    }
}
