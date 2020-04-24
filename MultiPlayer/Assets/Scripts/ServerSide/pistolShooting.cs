
using UnityEngine;

public class pistolShooting : Bolt.EntityBehaviour<ICustomCubeState>
{
    public Rigidbody bulletPrefab;
    public float bulledSpeed;
    public GameObject muzzle;

    public override void Attached()
    {
        state.OnShoot = Shoot;
    }
    public void Shoot()
    {
        Rigidbody bulletClone = Instantiate(bulletPrefab, muzzle.transform.position, this.transform.rotation);
        bulletClone.velocity = transform.TransformDirection(new Vector3(0, 0, bulledSpeed));
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && entity.IsOwner)
        {
            state.Shoot();
        }
    }
}
