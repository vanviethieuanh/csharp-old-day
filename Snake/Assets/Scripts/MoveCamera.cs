using UnityEngine;

public class MoveCamera : MonoBehaviour {

    public GameObject target;
    public float SmoothSpeed;

	// Update is called once per frame
	void FixedUpdate () {
        if(target.transform.position.y > transform.position.y)
            transform.position = Vector3.Lerp(transform.position,
            new Vector3(0, target.transform.position.y, -10),
            SmoothSpeed);
	}
}
