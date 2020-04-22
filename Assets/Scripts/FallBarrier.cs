using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallBarrier : MonoBehaviour
{
    private GameMaster gm;

    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
