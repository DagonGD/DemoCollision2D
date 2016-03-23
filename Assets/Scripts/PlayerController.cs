using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D _rigidBody;

    private const float InitialForce = 5;

	// Use this for initialization
	void Start ()
	{
	    _rigidBody = GetComponent<Rigidbody2D>();
	    _rigidBody.AddForce(new Vector2(Random.Range(-InitialForce, InitialForce), Random.Range(-InitialForce, InitialForce)), ForceMode2D.Impulse);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        _rigidBody.AddForce(new Vector2(0,5), ForceMode2D.Impulse);
    }
}
