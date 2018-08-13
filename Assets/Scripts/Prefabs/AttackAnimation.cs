using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackAnimation : MonoBehaviour {

    private float DestroyTime = 0.3f;

	// Use this for initialization
	void Start () {
        Destroy(gameObject, DestroyTime);
	}
}
