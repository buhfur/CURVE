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
}
