using Unity.VectorGraphics;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public static GameManager instance;
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

	public void GameOver()
	{
		UIManager.instance.Death();
	}
    public void Reset()
    {
		UIManager.instance.CloseDeath();
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
