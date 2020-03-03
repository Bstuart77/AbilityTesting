
using UnityEngine;


public class Movement : Bolt.EntityBehaviour<ICustomCubeState>
{
    private float sens = 100f;
    public Transform playerbody;
    private float xRotate = 0;
    private float yRotate = 0;

    public override void Attached()
    {
        state.SetTransforms(state.CubeTransform, gameObject.transform);
    }

   /* private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }*/

    public override void SimulateOwner()
    {
        var speed = 25f;
        var movement = Vector3.zero;
      
       


        if (Input.GetKey(KeyCode.A))
        {
            movement.x -= 1f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            movement.x += 1f;
        }
        if (Input.GetKey(KeyCode.W))
        {
            movement.z += 1f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            movement.z -= 1f;
        }

        if (movement != Vector3.zero)
        {
            transform.position = transform.position + movement.normalized * speed * BoltNetwork.FrameDeltaTime;
        }

        float mouseX = Input.GetAxis("Mouse X") * sens * BoltNetwork.FrameDeltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sens * BoltNetwork.FrameDeltaTime;

        xRotate -= mouseY;
        yRotate += mouseX;

        xRotate = Mathf.Clamp(xRotate, -90, 90);

       
        transform.localRotation = Quaternion.Euler(xRotate, yRotate, 0f);
        playerbody.Rotate(Vector3.up * mouseX);
        playerbody.Rotate(Vector3.left * mouseY);
    }
}
