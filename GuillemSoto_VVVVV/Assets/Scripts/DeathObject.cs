using UnityEngine;

public class DeathObject : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
			GameManager.instance.GameOver();
		}
    }
}
