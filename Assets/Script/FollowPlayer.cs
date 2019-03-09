using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

	public Transform target; //ターゲットへの参照
	private Vector3 offset;

	void Start ()
	{
		offset = GetComponent<Transform>().position - target.position;
	}

	void Update ()
	{
		GetComponent<Transform>().position = target.position + offset;
	}
}
