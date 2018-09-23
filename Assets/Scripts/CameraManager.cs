using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour {
  public CharacterController player;
  public Camera FirstPersonCamera;
  public Camera SmoothFloatingCamera;

  void Start() {
    UseSmoothFloatingCamera();
    Debug.Log("CameraManager");
  }

  // Update is called once per frame
  void Update() {
    if (SmoothFloatingCamera.enabled) {
      Vector3 playerPos = player.transform.position;
      // TODO Fix camera position.
      SmoothFloatingCamera.transform.position = new Vector3(playerPos.x, playerPos.y, 3f);
    }
  }

  void UseSmoothFloatingCamera() {
    FirstPersonCamera.enabled = false;
    SmoothFloatingCamera.enabled = true;
  }

  void UseFirstPersonCamera() {
    SmoothFloatingCamera.enabled = false;
    FirstPersonCamera.enabled = true;
  }
}
