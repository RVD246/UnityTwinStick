using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunEnemyHard : MonoBehaviour
{
    public EnemyBulletController enemyBullet;

    public float Ebulletspeed;

    public float timer;

    private float timeinitial;

    public Transform enemygunspawn;

    // Start is called before the first frame update
    void Start()
    {
        timeinitial = timer;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            EnemyBulletController newenemybullet = Instantiate(enemyBullet, enemygunspawn.position, enemygunspawn.rotation) as EnemyBulletController;
            EnemyBulletController newenemybullet2 = Instantiate(enemyBullet, enemygunspawn.position + new Vector3(1, 1, 1), enemygunspawn.rotation) as EnemyBulletController;
            EnemyBulletController newenemybullet3 = Instantiate(enemyBullet, enemygunspawn.position + new Vector3(2, 2, 2), enemygunspawn.rotation) as EnemyBulletController;
            newenemybullet.ebulletspeed = Ebulletspeed;
            newenemybullet2.ebulletspeed = Ebulletspeed;
            newenemybullet3.ebulletspeed = Ebulletspeed;
            timer = timeinitial;
        }
    }
}
