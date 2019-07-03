using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthManager : MonoBehaviour
{
    public int playerhealth;

    private int starthealth;

    // Start is called before the first frame update
    void Start()
    {
        starthealth = playerhealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerhealth <= 0)
            Destroy(gameObject);
    }

    public void hurtplayer(int damage)
    {
        playerhealth -= damage;
    }
}
