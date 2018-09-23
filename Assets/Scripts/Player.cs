using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

  public float gravity = 20f;
  public float walkSpeed = 20f;
  public float jumpSpeed = 6f;

  private Vector3 moveDirection = Vector3.zero;

  // Start is called before the first frame update
  void Start() {

  }

  // Update is called once per frame
  void Update() {
    // Get a reference of our player object.
    CharacterController controller = GetComponent<CharacterController>();
    // All the logic related to the input goes there.
    InputController(controller);
  }


  void InputController(CharacterController controller) {

    moveDirection.x = Input.GetAxis("Horizontal") * walkSpeed;

    if (Input.GetButton("Jump")) {
      moveDirection.y = jumpSpeed;
    }

    // Apply gravity
    moveDirection.y -= gravity * Time.deltaTime;
    // Move the character with the new vector
    controller.Move(moveDirection * Time.deltaTime);

  }
}
