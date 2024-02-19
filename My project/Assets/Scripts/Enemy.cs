using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    [SerializeField]private NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent.SetDestination(new Vector3(1f,0.5f,-2f));       
    }

    // Update is called once per frame
    void Update()
    {

    }

	private void OnCollisionEnter(Collision collision)
	{
		if(collision.gameObject.tag=="Finish"){
            Destroy(gameObject);
        }
	}
}
