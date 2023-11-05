using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Flock/Behaviour/Stay in Radius")]
public class StayInRadiusBehaviour : FlockBehaviour
{
    public Vector3 center;
    public float radius = 15f;

	public override Vector3 CalculateMove(FlockAgent agent, List<Transform> context, Flock flock, GameObject target)
	{
		Vector3 centerOffset = center - (Vector3)agent.transform.position;
		float t = centerOffset.magnitude / radius;
		if(t < 0.9)
		{
			return Vector3.zero;
		}

		return centerOffset * t * t;
	}
}
