using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitLaunch : MonoBehaviour
{
    public Rigidbody fruit;
    // Start is called before the first frame update
    void Start()
    {
        fruit.velocity = new Vector3(0, 20, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
