using UnityEngine;

public class Ball : MonoBehaviour {

    public Rigidbody2D rb;
    public float speed;

	// Use this for initialization
	void Start () {
		Launch();
	}

    private void Launch()
    {
        var x = Random.Range(0, 1) == 0 ? -1 : 1;
        var y = Random.Range(0, 1) == 0 ? -1 : 1;
        rb.velocity = new Vector2(speed * x, speed * y);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
