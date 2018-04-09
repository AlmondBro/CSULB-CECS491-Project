using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class AI_Ship_DecisionTree : MonoBehaviour
{
	public enum AIState
	{
		Patrol,
		Attack
	}

	public AIState State
	{
		get { return State; }

		set
		{
			if(value == AIState.Patrol)
			{
				OnPatrol();
			}
			else if(value == AIState.Attack)
			{
				OnAttack();
			}
		}
	}

	AI_Patrol_Movement patrolMovement;
	AI_Ship_Attack shipAttack;
	AI_Ship_TargetSelection shipTargetSelection;
	AI_Aim_Manager aimManager;

	void Start()
	{
		patrolMovement = GetComponent<AI_Patrol_Movement>();
		shipAttack = GetComponent<AI_Ship_Attack>();
		shipTargetSelection = GetComponent<AI_Ship_TargetSelection>();
		aimManager = shipAttack.WeaponLocation.GetComponent<AI_Aim_Manager>();

		State = AIState.Patrol;
	}

	// JEREMY!!!  SINCE YOUR DODGE IS NOT DEPENDENT ON WHETHER AN ENEMY IS INSIDE THE FIELD OF VIEW, YOU PROBABLY CAN'T PUT IT IN THESE

	void OnPatrol()
	{
		Debug.Log("Patrol");
		patrolMovement.enabled = true;
		aimManager.enabled = false;
		shipAttack.enabled = false;
		shipTargetSelection.enabled = false;
		// JEREMY!!! PUT YOUR MOVEMENT SHITE HERE AND SET TO FALSE
	}

	void OnAttack()
	{
		Debug.Log("Attack");
		patrolMovement.enabled = false;
		aimManager.enabled = true;
		shipAttack.enabled = true;
		shipTargetSelection.enabled = true;
		// JEREMY!!! PUT YOUR MOVEMENT SHITE HERE AND SET TO TRUE
	}
}
