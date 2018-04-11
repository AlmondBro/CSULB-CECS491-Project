using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

/// <summary>
/// Finds the closest Target based on the Enemies List in AI_Ship_FieldOfView
/// </summary>
public class AI_Ship_TargetSelection : MonoBehaviour
{
	public GameObject ClosestTarget { get; private set; }       // The closest Target

	[SerializeField] float updateTargetCount;                   // How long the system waits to update its targets

	AI_Ship_FieldOfViewController fieldOfView;                  // Reference to the FieldOfView Script
	Coroutine updateTargets;                                    // Stores a reference to the CoUpdateTargets Coroutine

	// Initialization
	void Start()
	{
		fieldOfView = GetComponentInChildren<AI_Ship_FieldOfViewController>();
	}

	/// <summary>
	/// Updates the targets with a certain margin
	/// </summary>
	/// <returns></returns>
	IEnumerator CoUpdateTargets()
	{
		while(true)
		{
			yield return new WaitForSeconds(updateTargetCount);
			ClosestTarget = FindClosestTarget();
		}
	}

	/// <summary>
	/// Finds the closest targets by interating through them
	/// </summary>
	/// <returns></returns>
	GameObject FindClosestTarget()
	{
		GameObject currentClosest = fieldOfView.enemies.Count == 0 ? null : fieldOfView.enemies[0];
		for(int i = 1; i < fieldOfView.enemies.Count; i++)
		{
			// Distance is calculated by subtracting the two vectors, calculating the length using magnitude and calling absolute value
			// to discard negatives
			float distance1 = Mathf.Abs((currentClosest.transform.position - transform.position).magnitude);
			float distance2 = Mathf.Abs((fieldOfView.enemies[i].transform.position - transform.position).magnitude);

			// If the currentClosest distance is greater than the distance at the index then set currentClosest to the index
			currentClosest = distance1 > distance2 ? fieldOfView.enemies[i] : currentClosest;
		}

		Debug.Log(currentClosest);

		return currentClosest;
	}

	/// <summary>
	/// Start the Coroutine CoUpdateTargets Everytime we Enable the script
	/// </summary>
	void OnEnable()
	{
		updateTargets = StartCoroutine(CoUpdateTargets());
	}

	/// <summary>
	/// Aparently Coroutines do not stop when you disable the script they are attached to
	/// This will stop the CoUpdateTargets Coroutine when the script is disabled
	/// </summary>
	void OnDisable()
	{
		StopCoroutine(updateTargets);   
	}

}
