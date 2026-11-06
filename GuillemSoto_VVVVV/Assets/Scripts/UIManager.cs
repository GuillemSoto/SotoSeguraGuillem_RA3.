using UnityEngine;

public class UIManager : MonoBehaviour
{
	public static UIManager instance;
	[SerializeField] private GameObject gameOverPanel;
	public void Awake()
	{
		if (instance == null)
		{
			instance = this;
			DontDestroyOnLoad(gameObject);
		}
		else
		{
			Destroy(gameObject);
		}
	}
	public void CloseDeath()
	{
		Time.timeScale = 1f;
		gameOverPanel.SetActive(false);
	}
	public void Death()
	{
		gameOverPanel.SetActive(true);
		Time.timeScale = 0f;
	}
}
