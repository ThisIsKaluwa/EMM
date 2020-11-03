using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{

    private float speed = 50.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        transform.Translate(0, 0, moveVertical*Time.deltaTime*speed);
        transform.Translate(moveHorizontal*Time.deltaTime*speed, 0, 0);

        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0, -1.0f * Time.deltaTime*speed, 0);
        }

        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0, 1.0f * Time.deltaTime*speed, 0);
        }

    }

}
