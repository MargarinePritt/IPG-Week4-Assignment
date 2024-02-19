using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    private float respawnTimer=0f;
    [SerializeField]private float respawnTime=3f;

    [SerializeField]private GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time>=respawnTimer){
            Instantiate(enemy,new Vector3(-5f,0.5f,5f),Quaternion.identity);
            Instantiate(enemy,new Vector3(5f,0.5f,5f),Quaternion.identity);
            respawnTimer=respawnTime+Time.time;
        }
    }
}
