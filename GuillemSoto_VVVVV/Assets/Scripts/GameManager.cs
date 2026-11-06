using Unity.VectorGraphics;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public static GameManager instance;
	[SerializeField] private GameObject gameOverPanel;
	public void Awake()
	{
		Time.timeScale = 1f;
		gameOverPanel.SetActive(false);
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

	public void GameOver()
	{
		gameOverPanel.SetActive(true);
		Time.timeScale = 0f;
	}
    public void Reset()
    {
		gameOverPanel.SetActive(false);
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
