using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playAgain : MonoBehaviour
{

	public void PlayAgain()
	{
			ScoreTextScript.Reset();
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
	}

}
