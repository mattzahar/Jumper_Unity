using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
      Destroy (gameObject);
      ScoreTextScript.coinAmount += 1;
    }
}
