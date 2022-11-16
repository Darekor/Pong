using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public GameObject ball;

	public GameObject p1Paddle;
	public GameObject p1Goal;

	public GameObject p2Paddle;
	public GameObject p2Goal;

	public GameObject p1Text;
	public GameObject p2Text;

	private int p1Score;
	private int p2Score;

	private Vector3 startPos;

	private void Start()
    {
		startPos = ball.transform.position;
    }

	private void Restart()
    {

    }

	public void ResetPosition()
    {
		ball.transform.position = startPos;
    }

	public void p1Scored()
    {
		p1Score++;
		p1Text.GetComponent<Text>().text = p1Score.ToString();
		ResetPosition();

	}

	public void p2Scored()
	{
		p2Score++;
		p2Text.GetComponent<Text>().text = p2Score.ToString();
		ResetPosition();
	}
}
