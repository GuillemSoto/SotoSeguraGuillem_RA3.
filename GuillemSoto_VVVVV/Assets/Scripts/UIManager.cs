using UnityEngine;

public class UIManager : MonoBehaviour
{
	public static UIManager instance;
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
}
