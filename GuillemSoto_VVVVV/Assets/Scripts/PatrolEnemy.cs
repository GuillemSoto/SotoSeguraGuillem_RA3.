using UnityEngine;

public class Patrol : MonoBehaviour
{
    private SpriteRenderer sr;
	private Rigidbody2D rb;
	public float speed = 5f;
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (sr.flipX)
        {
            rb.linearVelocityX = -speed;
        }
        else
        {
            rb.linearVelocityX = speed;
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.instance.GameOver();
        }
		if (other.CompareTag("Pivot"))
		{
            sr.flipX = !sr.flipX;
		}
	}
}
