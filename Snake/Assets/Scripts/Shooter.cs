using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {

    public GameObject Bullet;
    public Transform Target;

	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0))
        {
            Vector2 difference = Target.position - transform.position;
            difference.Normalize();
            float rotation_z = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
            Quaternion shootingrotate = Quaternion.Euler(0f, 0f, rotation_z);

            Destroy(Instantiate(Bullet, transform.position, shootingrotate), 3);
        }
	}


}
