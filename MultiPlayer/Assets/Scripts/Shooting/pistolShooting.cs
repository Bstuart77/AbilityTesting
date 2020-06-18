using UnityEngine;
public class PistolShooting : Bolt.EntityBehaviour<ICustomCubeState>

{
    public Rigidbody bulletPrefab;
    public float bulledSpeed;
    public GameObject muzzle;
    public Score scoreScript;
    public override void Attached()
    {
        state.OnShoot = Shoot;
    }
    public void Shoot()
    {
        Rigidbody bulletClone = Instantiate(bulletPrefab, muzzle.transform.position, this.transform.rotation);
        bulletClone.velocity = transform.TransformDirection(new Vector3(0, 0, bulledSpeed));
        bulletClone.GetComponent<Bullet>().shootingScript = this;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && entity.IsOwner)
        {
            state.Shoot();
        }
    }
}
