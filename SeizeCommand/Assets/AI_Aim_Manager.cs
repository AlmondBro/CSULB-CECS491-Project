using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Aim_Manager : AbstractAimManager
{
	[SerializeField] float rot_speed;

	AI_Ship_TargetSelection targetSelector;

	private Unit unit;

	void Start()
	{
		targetSelector = transform.root.GetComponent<AI_Ship_TargetSelection>();
		unit = GetComponentInParent<Unit>();
	}

	void Update()
	{
		Aim();    
	}

	protected override void Aim()
	{
		GameObject target = targetSelector.ClosestTarget;


		if(target)
		{
			unit.setTransform(target.transform.position); //Set path to player

			Vector3 distance = target.transform.position - transform.position;
			distance.Normalize();
			float rotation_z = Mathf.Atan2(distance.y, distance.x) * Mathf.Rad2Deg;
			Quaternion rot = Quaternion.Euler(0f, 0f, rotation_z + -90);

			transform.rotation = Quaternion.RotateTowards(transform.rotation, rot, rot_speed * Time.deltaTime);
		}
	}

}