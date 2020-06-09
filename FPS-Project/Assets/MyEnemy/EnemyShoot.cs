using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
	public void GotShot()
	{
		EnemyMovement behavior = GetComponent<EnemyMovement>();
		if (behavior != null)
		{
			behavior.SetAlive(false);
		}

		StartCoroutine(Die());
	}

	private IEnumerator Die()
	{
		//Debug.Log("I killed Player!");
		this.transform.Rotate(-75, 0, 0);
		

		yield return new WaitForSeconds(1.5f);

		Destroy(this.gameObject);
	}

}