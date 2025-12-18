using UnityEngine;
using UnityEngine.AI;

public class EnemyAI2 : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    public bool Move;
    public NavMeshAgent enemy;
    private Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame this is for pathfinding for enemies
    void Update()
    {
        if (Move == true)
        {
            enemy.SetDestination(pointA.position);
            if (!enemy.pathPending)
            {
                if (enemy.remainingDistance <= enemy.stoppingDistance)
                {
                    enemy.SetDestination(pointB.position);
                    Move = false;
                }

            }

        }
        else
        {
            enemy.SetDestination(pointB.position);
            if (!enemy.pathPending)
            {
                if (enemy.remainingDistance <= enemy.stoppingDistance)
                {
                    Move = true;
                }

            }

        }
    }
}
