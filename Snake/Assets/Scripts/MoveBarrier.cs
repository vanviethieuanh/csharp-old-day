using UnityEngine;

public class MoveBarrier : MonoBehaviour {

    public float Speed;

    public float Min;
    public float Max;

	// Update is called once per frame
	void Update () {
        if (transform.position.x > Max && Speed > 0)
            Speed *= -1;
        if (transform.position.x < Min && Speed < 0)
            Speed *= -1;
        transform.Translate(new Vector2(Speed * Time.deltaTime,0));
	}
}
