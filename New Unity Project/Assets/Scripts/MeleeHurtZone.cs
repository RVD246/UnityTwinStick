using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeHurtZone : MonoBehaviour
{
    public Transform hurtzone;

    public PlayerHealthManager player;

    // Start is called before the first frame update
    void Start()
    {
        hurtzone = gameObject.GetComponent<Transform>();
        player = FindObjectOfType<PlayerHealthManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "player")
        {
            player.hurtplayer(2);
        }
    }
}
