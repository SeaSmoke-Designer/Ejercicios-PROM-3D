using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
	[SerializeField] private float speedRotate;
	void Update()
	{
		transform.Rotate(Vector3.up * speedRotate * Time.deltaTime);
	}
}
