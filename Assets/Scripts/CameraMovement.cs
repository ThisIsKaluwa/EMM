using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public GameObject player;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
        Quaternion rotation = player.GetComponent<PlayerBehaviour>().getRotation();
        transform.rotation = rotation;
        //transform.position = player.transform.position + offset;
        transform.position = player.transform.position + rotation * offset;
    }
}
