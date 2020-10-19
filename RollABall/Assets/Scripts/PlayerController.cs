using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerController : MonoBehaviour
{
	public float speed;
	public TextMeshProUGUI countText;
	public GameObject winTextObject;

	private float movementX;
	private float movementY;

	private Rigidbody rb;

	private int count;

	// Start is called before the first frame update
	private void Start()
	{
		rb = GetComponent<Rigidbody>();
		count = 0;
		
		SetCountText();
		winTextObject.SetActive(false);
	}

	private void FixedUpdate()
	{
		var movement = new Vector3(movementX, 0.0f, movementY);

		rb.AddForce(movement * speed);
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("PickUp"))
		{
			other.gameObject.SetActive(false);
			count++;
			
			SetCountText();
		}
	}

	void SetCountText()
	{
		countText.text = "Count: " + count.ToString();
		if (count >= 12)
		{
			winTextObject.SetActive(true);
		}
	}

	private void OnMove(InputValue movementValue)
	{
		var movementVector = movementValue.Get<Vector2>();

		movementX = movementVector.x;
		movementY = movementVector.y;
	}
}