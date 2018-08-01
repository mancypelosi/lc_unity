using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This code attached to the FloatingText prefab object
public class FloatingText : MonoBehaviour {

	// Use this for initialization
	void Start () {
        float DestroyTime = 1f;
        Destroy(gameObject, DestroyTime);
	}
}
