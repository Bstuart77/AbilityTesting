
using UnityEngine;


public class Movement : Bolt.EntityBehaviour<ICustomCubeState>
{
    public Transform playerbody;
    private static float moveSpeed = 100f;
    private float xRotate = 0;
    private float yRotate = 0;
    private Rigidbody rb;
    private float sensHelper;


    public override void Attached()
    {
        state.SetTransforms(state.CubeTransform, gameObject.transform);
    }

   private void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
        rb = GetComponent<Rigidbody>();

        state.WeaponActiveIndex = 0;
        gameObject.GetComponent<shootAR>().enabled = false;
        gameObject.GetComponent<PistolShooting>().enabled = true;
    }

    public override void SimulateOwner()
    {
        Vector3 movement = new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed *BoltNetwork.FrameDeltaTime, 0, Input.GetAxisRaw("Vertical") * moveSpeed * BoltNetwork.FrameDeltaTime);

        Vector3 newPos = rb.position + rb.transform.TransformDirection(movement);

        rb.MovePosition(newPos);

        //weapon swapping
        if (Input.GetKey(KeyCode.Alpha1))   //PISTOL
        {
            state.WeaponActiveIndex = 0;
            gameObject.GetComponent<shootAR>().enabled = false;
            gameObject.GetComponent<PistolShooting>().enabled = true;

        }
        if (Input.GetKey(KeyCode.Alpha2))   //AR
        {
            gameObject.GetComponent<PistolShooting>().enabled = false;
            gameObject.GetComponent<shootAR>().enabled = true;

            state.WeaponActiveIndex = 1;
        }
        //free look
        sensHelper = PlayerPrefs.GetFloat("sens");

        float mouseX = Input.GetAxis("Mouse X") * sensHelper * BoltNetwork.FrameDeltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensHelper * BoltNetwork.FrameDeltaTime;

        xRotate -= mouseY;
        yRotate += mouseX;

        xRotate = Mathf.Clamp(xRotate, -90, 90);

       
        transform.localRotation = Quaternion.Euler(xRotate, yRotate, 0f);
        playerbody.Rotate(Vector3.up * mouseX);
        playerbody.Rotate(Vector3.left * mouseY);
    }
}
