using UnityEngine;

public class CubeController : MonoBehaviour {

    [Header("Parameter")]
    public float Force;
    public float Range;
    [Range(0, 1)]
    public float LimitHorizontal;
    public float LimitForce;
    public float IdleMove = 2;
    [Range(0, 1)]
    public float Slowdown;
    [Space]

    [Header("GameOject")]
    public GameObject DeadEffect;
    public GameObject Mouse;
    public GameObject shooting;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetMouseButton(0))
        {
            Vector2 touchPos = Mouse.transform.position;
        }
        if (rb.velocity.x == 0 && rb.velocity.y == 0)
        {
            RandomMove();
        }
        if (rb.velocity.x + rb.velocity.y >= 20)
        {
            rb.velocity *= (Slowdown * Time.deltaTime);
        }
    }

    void RandomMove()
    {
        rb.AddForce(new Vector2(Random.Range(-1 * IdleMove, IdleMove), Random.Range(-1 * IdleMove, IdleMove)));
    }

    void Push(Vector2 pushPos)
    {
        RaycastHit2D hit = Physics2D.Raycast(pushPos,
                   new Vector2(transform.position.x, transform.position.y) - pushPos, 100f);
        float distance = Vector2.Distance(pushPos,transform.position);

        if (distance < Range)
        {
            float ratio = Range / distance;
            Vector2 vForce = Force * hit.normal * -1 * ratio;
            vForce.x *= LimitHorizontal;
            if (vForce.x != float.NegativeInfinity)
            {
                if (vForce.x < LimitForce && vForce.y < LimitForce)
                {
                    rb.AddForceAtPosition(vForce, hit.point);
                }
            }

        }

    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Barier"))
        {
            Destroy(Instantiate(DeadEffect, transform.position,Quaternion.identity),5);
        }
        if (collision.CompareTag("Gem"))
        {
            Destroy(collision.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Push(Mouse.transform.position);
    }

}
