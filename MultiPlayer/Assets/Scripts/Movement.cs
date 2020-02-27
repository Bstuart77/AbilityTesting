
using UnityEngine;


public class Movement : Bolt.EntityBehaviour<ICustomCubeState>
{
    //void start
    public override void Attached()
    {
        state.SetTransforms(state.CubeTransform, gameObject.transform);
    }

    //void update
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
    }
}
