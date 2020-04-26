using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        GameMaster gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        gm.lastCheckPointPos = new Vector2((float)-19.5, (float)-0.06);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
