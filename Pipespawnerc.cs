using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipespawnerc : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject pipe;
    public float spawnRate = 2;
    private float timer;
    public float heightOffset = 10;
    void Start()
    {
        spawn();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnRate){
            timer = timer + Time.deltaTime;
        }
        else{
            spawn();
            timer = 0;
        }
       
    }
    void spawn(){
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Instantiate(pipe, new Vector3(transform.position.x , Random.Range(lowestPoint , highestPoint ) , 0) , transform.rotation); 
    }
}
