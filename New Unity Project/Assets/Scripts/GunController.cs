using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    public bool isFiring;

    public bool gun1 = true;
    public bool gun2;
    public bool gun3;
    
    public BulletController bullet;
    public float bulletSpeed;

    public float timeBetweenShots;
    private float shotCounter;

    public Transform firepoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            gun1 = true;
            gun2 = gun3 = false;
        }
        if (Input.GetKeyDown("2"))
        {
            gun2 = true;
            gun1 = gun3 = false;
        }
        if (Input.GetKeyDown("3"))
        {
            gun3 = true;
            gun2 = gun1 = false;
        }
        if (gun1)
        {
            if (isFiring)
            {
                shotCounter -= Time.deltaTime;
                if (shotCounter <= 0)
                {
                    shotCounter = timeBetweenShots;
                    BulletController newbullet = Instantiate(bullet, firepoint.position, firepoint.rotation) as BulletController;
                    newbullet.speed = bulletSpeed;
                    isFiring = false;
                }
                else
                    shotCounter = 0;
            }
        }
        if (gun2)
        {
            if (isFiring)
            {
                shotCounter -= Time.deltaTime;
                if (shotCounter <= 0)
                {
                    shotCounter = timeBetweenShots;
                    BulletController newbullet = Instantiate(bullet, firepoint.position, firepoint.rotation) as BulletController;
                    BulletController newbullet1 = Instantiate(bullet, firepoint.position + new Vector3 (3, 0, 0), firepoint.rotation) as BulletController;
                    BulletController newbullet2 = Instantiate(bullet, firepoint.position + new Vector3(-3, 0, 0), firepoint.rotation) as BulletController;
                    newbullet.speed = bulletSpeed;
                    newbullet1.speed = bulletSpeed;
                    newbullet2.speed = bulletSpeed;
                    isFiring = false;
                }
                else
                    shotCounter = 0;
            }
        }
    }
}
