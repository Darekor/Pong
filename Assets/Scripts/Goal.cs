using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour {

	public bool isPlayer1Goal;

    public GameObject gameManager;

	private void OnTriggerEnter2D(Collider2D collider)
    {
        if (isPlayer1Goal)
            gameManager.GetComponent<GameManager>().p1Scored();
        else
            gameManager.GetComponent<GameManager>().p2Scored();
    }
}
