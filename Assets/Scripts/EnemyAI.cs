using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    NavMeshAgent agent;
    Transform player;

    [SerializeField] LayerMask groundLayer, playerLayer;

    //Patrolling
    Vector3 Dest;
    bool Walkpoint;
    [SerializeField] float Walkrange;

    //States
    [SerializeField] float sightRange;
    bool playerInSight;

    void Start()
    {
        player = GameObject.Find("Player").transform;
        agent = GetComponent<NavMeshAgent>();
        DestSearch();
    }

    // Update is called once per frame
    void Update()
    {
        playerInSight = Physics.CheckSphere(transform.position, sightRange, playerLayer);

        if(!playerInSight) Patrolling();
        if(playerInSight) ChasePlayer();
    }

    void Patrolling()
    {
        if (!Walkpoint) 
        {
            DestSearch();
        }
        if (Walkpoint) 
        {
            agent.SetDestination(Dest);
        }

        if (Vector3.Distance(transform.position, Dest) < 10) 
        {
            Walkpoint = false;
        }
    }

    void ChasePlayer()
    {
        agent.SetDestination(player.position);
    }

    void DestSearch()
    { 
        float z = Random.Range(-Walkrange, Walkrange);
        float x = Random.Range(-Walkrange, Walkrange);

        Dest = new Vector3(transform.position.x + x, transform.position.y, transform.position.z + z);

        if (Physics.Raycast(Dest, Vector3.down, groundLayer))
        {
            Walkpoint = true;
        }
    }
}
