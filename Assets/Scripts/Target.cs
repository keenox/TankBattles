using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public int damageTaken = 25;

	public void Hit()
	{
        gameObject.GetComponent<Health>().TakeDamage(damageTaken);
	}
}
