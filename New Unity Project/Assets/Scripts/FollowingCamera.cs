using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingCamera : MonoBehaviour
{
    private Camera mainCamera;

    private PlayerController player;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = FindObjectOfType<Camera>();
        player = FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        mainCamera.transform.position = player.transform.position + new Vector3(-1.2f, 67.7f, 4f);
    }
}
