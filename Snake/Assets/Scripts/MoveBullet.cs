using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullet : MonoBehaviour {

    [Header("Parameter")]
    public float Speed;
    public float LifeTime;
    
    public GameObject ShootEffect;

	void Update () {
        transform.Translate(Speed * Vector2.right);
	}

    private void OnCollisionEnter2D(Collision2D col)
    {
        Destroy(Instantiate(ShootEffect, transform.position, Quaternion.identity),3f);
        Destroy(gameObject);
    }
}
