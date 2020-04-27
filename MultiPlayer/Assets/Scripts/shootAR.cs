using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootAR : Bolt.EntityBehaviour<ICustomCubeState>
{
    public Rigidbody bulletPrefab;
    public float bulledSpeed;
    public GameObject muzzle;

    public float fireRate = 15f;
    private float nextTimeToFire = 0f;
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
        if (Input.GetKey(KeyCode.Mouse0) && entity.IsOwner && Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + 1.5f / fireRate;
            state.Shoot();
        }
    }
}