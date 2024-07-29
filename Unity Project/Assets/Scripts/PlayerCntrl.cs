using UnityEngine;

public class PlayerCntrl : MonoBehaviour
{
    public Transform cam;

    public float maxCamYAngle = 90f;
    public float moveSpeed = 4f;
    public float jumpForce = 6f;
    public float sensitivity = 4f;

    private float camX = 0f;
    private float camY = 0f;

    private float velocity = 0f;
    private bool isGrounded = false;
    private Vector3 spawnPos;
    private bool jumpBtnPressed = false;
    private bool isMobile = false;

    private CharacterController controller;
    private Transform trans;

    public static PlayerCntrl Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            DestroyImmediate(gameObject);
        }
        isMobile = Application.isMobilePlatform;
    }

    private void OnDestroy()
    {
        if (Instance == this)
        {
            Instance = null;
        }
    }

    private void Start()
    {
		if (isMobile == true)
		{
			sensitivity = 120f;
		}
        controller = GetComponent<CharacterController>();
	
        trans = transform;
        spawnPos = transform.position;
    }

    private void Update()
    {
        if (Time.timeScale == 0) return;
        if (!isMobile) {
            camX += Input.GetAxis("Mouse X") * sensitivity;
            camY += Input.GetAxis("Mouse Y") * sensitivity;
            camY = Mathf.Clamp(camY, -maxCamYAngle, maxCamYAngle);
        }
        else
        {
            camX = JoystickRight.rotX;
            camY = JoystickRight.rotY;
        }

        trans.rotation = Quaternion.Euler(0f, camX, 0f);
        cam.localRotation = Quaternion.Euler(-camY, 0f, 0f);

        isGrounded = controller.isGrounded;
        velocity -= 9.81f * Time.deltaTime;
        if (controller.isGrounded && velocity < 0f) velocity = 0f;

        if ((Input.GetKey(KeyCode.Space) || jumpBtnPressed) && isGrounded)
        {
            velocity += jumpForce;
        }

        Vector3 moveVector;
        if (!isMobile) moveVector = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, velocity, Input.GetAxis("Vertical") * moveSpeed);
        else moveVector = new Vector3(JoystickLeft.positionX * moveSpeed, velocity, JoystickLeft.positionY * moveSpeed);
        controller.Move(trans.TransformDirection(moveVector) * Time.deltaTime);
    }

    public void JumpBtnStateChanged(bool state)
    {
        jumpBtnPressed = state;
    }

    public void Restart()
    {
        controller.enabled = false;
        trans.position = spawnPos;
        controller.enabled = true;
        velocity = 0f;
    }
}
