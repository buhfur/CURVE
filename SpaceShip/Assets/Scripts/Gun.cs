using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public bool isFullAuto;
    [SerializeField]
    private Transform bulletSpawn;
    [SerializeField]
    private GameObject bulletPrefab;
    [SerializeField]
    private ParticleSystem muzzleFlash;
    [SerializeField]
    private AudioSource gunShot;
    [SerializeField]
    private float fireRate;
    [SerializeField]
    private float bulletDamage;
    [SerializeField]
    private Shooter myOwner;

    [SerializeField]
    private float bulletSpreadRadius;


    public void Shoot(Vector3 aimTarget)
    {
        muzzleFlash.Play();

        gunShot.Play();

        GameObject tempBullet =
            Instantiate(bulletPrefab, bulletSpawn.position,
            bulletSpawn.rotation);

        tempBullet.transform.LookAt(aimTarget);

        Bullet currentBullet =
            tempBullet.GetComponent<Bullet>();

        currentBullet.damage = bulletDamage;

        currentBullet.owner = myOwner;


        float bulletDirectionX = Random.Range(-bulletSpreadRadius, bulletSpreadRadius);

        float bulletDirectionY = Random.Range(-bulletSpreadRadius, bulletSpreadRadius);

        currentBullet.ShootBullet(currentBullet.transform.TransformDirection(
            new Vector3(bulletDirectionX, bulletDirectionY, 1)));
    }
}
