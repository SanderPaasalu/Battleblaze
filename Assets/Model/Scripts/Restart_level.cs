using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Restart_level : MonoBehaviour
{
	public void TaskOnClick()
	{
		SceneManager.LoadScene("Mainscene");
	}
}