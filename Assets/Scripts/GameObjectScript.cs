using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectScript : MonoBehaviour
{

    public Transform myPrefab;
    public int random;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < random; i++)
        {
            //Instantiate(myPrefab, new Vector3(i * 3.0f, 1, 1), Quaternion.identity);
            Vector3 randomPos = new Vector3(Random.Range(-500, 500), 2, Random.Range(-500, 500));
            Transform newObject = Instantiate(myPrefab, randomPos, Quaternion.identity);

        }
    }

    // Update is called once per frame
    void Update()
    {
        myPrefab.Rotate(0,50*Time.deltaTime,0);

    }
}
