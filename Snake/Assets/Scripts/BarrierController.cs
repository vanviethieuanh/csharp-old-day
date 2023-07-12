using UnityEngine;

public class BarrierController : MonoBehaviour {

    public GameObject[] Barriers;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Barrier"))
        {
            Destroy(collision.gameObject);
            // create new barrier
            Instantiate(Barriers[Random.Range(0, Barriers.Length - 1)],
                new Vector2(0,transform.position.y + 10f),
                Quaternion.identity);
        }
    }
}
