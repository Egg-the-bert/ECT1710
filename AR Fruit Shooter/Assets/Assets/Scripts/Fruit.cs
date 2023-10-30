using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    public Transform spawn;
    public GameObject Apple;
    public GameObject Bananna;
    public GameObject Gourd;
    public GameObject Mandarin;
    public float spawnTimer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer += Time.deltaTime;

        
    }

    private void FixedUpdate()
    {
        if (spawnTimer > 3) 
        { 
            SpawnFruit();
            spawnTimer = 0;
        }
    }

    public void SpawnFruit()
    {
        float spawnY =  spawn.position.y;
        int randNum = Random.Range(1, 4);

        if (randNum == 1)
        {
            Instantiate(Apple);

            //if (Apple < spawnY)
            {

            }
        }
        if (randNum == 2)
        {
            Instantiate(Bananna);
        }
        if (randNum == 3)
        {
            Instantiate(Gourd);
 
        }
        if (randNum == 4)
        {
            Instantiate(Mandarin);
        }
    }
    
}
