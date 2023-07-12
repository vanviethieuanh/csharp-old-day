using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBarrier : MonoBehaviour {

    public float Speed = 45;

	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(0, 0, Speed * Time.deltaTime));
	}
}
