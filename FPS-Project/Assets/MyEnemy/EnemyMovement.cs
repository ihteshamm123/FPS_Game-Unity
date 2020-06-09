using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
	public float speed = 3.0f;
	public float obstacleRange = 5.0f;

	private bool _alive;

	public GameObject paintballPrefab;
	private GameObject _paintball;

	void Start()
	{
		_alive = true;
	}

	void Update()
	{
		if (_alive)
		{
			transform.Translate(0, 0, speed * Time.deltaTime);
		}

		Ray ray = new Ray(transform.position, transform.forward);
		RaycastHit hit;
		if (Physics.SphereCast(ray, 0.75f, out hit))
		{
			GameObject hitObject = hit.transform.gameObject;
			if (hitObject.GetComponent<PlayerHealth>())
			{
				if (_paintball == null)
				{
					_paintball = Instantiate(paintballPrefab) as GameObject;
					_paintball.transform.position = transform.TransformPoint(Vector3.forward * 1.5f);
					_paintball.transform.rotation = transform.rotation;
				}
			}
			else if (hit.distance < obstacleRange)
			{
				float angle = Random.Range(-110, 110);
				transform.Rotate(0, angle, 0);
			}
		}
	}

	public void SetAlive(bool alive)
	{
		_alive = alive;
	}
}