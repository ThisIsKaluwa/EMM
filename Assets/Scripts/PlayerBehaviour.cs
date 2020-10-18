using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{

    private Quaternion lookRotation;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        transform.Translate(0, 0, moveVertical);
        transform.Translate(moveHorizontal, 0, 0);

        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0, -1.0f, 0);
        }

        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0, 1.0f, 0);
        }

        lookRotation = Quaternion.LookRotation(transform.forward);
    }

    public Quaternion getRotation(){
        return lookRotation;
    }
}
