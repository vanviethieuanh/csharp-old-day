using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    public float moveSpeed = 0.004f;
    void FixedUpdate()
    {
        transform.position = Vector2.Lerp(transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition), moveSpeed);
       
    }
}