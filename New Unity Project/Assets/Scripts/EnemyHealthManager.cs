using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour
{
    public int health;

    private int currenthealth;

    // Start is called before the first frame update
    void Start()
    {
        currenthealth = health;
    }

    // Update is called once per frame
    void Update()
    {
        if (currenthealth <= 0)
            Destroy(gameObject);
    }

    public void hurtenemy(int damage)
    {
        currenthealth -= damage;
    }
}
