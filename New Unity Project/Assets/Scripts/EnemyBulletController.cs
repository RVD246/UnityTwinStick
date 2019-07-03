using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletController : MonoBehaviour
{
    public float ebulletspeed;

    public float elifetime;

    public int edamagetogive;

    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-Vector3.down * ebulletspeed * Time.deltaTime);
        elifetime -= Time.deltaTime;
        if (elifetime <= 0)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "player")
        {
            other.gameObject.GetComponent<PlayerHealthManager>().hurtplayer(edamagetogive);
            Destroy(gameObject);
        }
    }
}
