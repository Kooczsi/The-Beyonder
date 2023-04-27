using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerMove : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Slider staminaBar;
    [SerializeField] private float walkSpeed;
    [SerializeField] private float runSpeed;
    private float moveSpeed;
	// Start is called before the first frame update
	



	Vector2 movement;
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

		if (Input.GetKey(KeyCode.LeftShift))
		{
            moveSpeed = runSpeed;
		}
		else
		{
			moveSpeed = walkSpeed;
		}
    }

	private void FixedUpdate()
	{
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
	}
}
