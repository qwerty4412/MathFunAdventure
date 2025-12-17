using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    GameObject player;
    NavMeshAgent agent;
    [SerializeField] LayerMask groundLayer, playerLayer;
    Vector3 Dest;
    bool Walkpoint;
    [SerializeField] float Walkrange;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 enemydirection = Vector3.zero;
        if (enemydirection != Vector3.zero)
        {
            transform.forward = enemydirection;
        }

        void Patrolling()
        {
            if (!Walkpoint) ;
            if (Walkpoint) agent.SetDestination(Dest);
            if (Vector3.Distance(transform.position, Dest) < 10) Walkpoint = false;
        }

        void DestSearch()
        { 
            
        }
    }
}
