using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class MyEnemy_FSM : MonoBehaviour
{

   /* public enum EMENY_STATE { PATROL, CHASE, ATTACK }



    [SerializeField]
    private EMENY_STATE currentState;

    public EMENY_STATE CurrentState
    {
        get { return currentState; }
        set
        {
            currentState = value;
            StopAllCoroutines();

            switch (currentState)
            {
                case EMENY_STATE.PATROL:
                    StartCoroutine(EnemyPatrol());
                    break;
                case EMENY_STATE.CHASE:
                    StartCoroutine(EnemyChase());
                    break;
                case EMENY_STATE.ATTACK:
                    StartCoroutine(EnemyAttack());
                    break;


            }


        }
    }
    private CheckMyVision checkMyVision;
    private UnityEngine.AI.NavMeshAgent agent = null;
    private Transform playerTransform = null;
    private Transform patrolDestination = null;

    private Health playerHealth = null;
    public float maxDemage = 10f;

    private void Awake()
    {
        checkMyVision = GetComponent<CheckMyVision>();
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        playerHealth = GameObject.FindGameObjectWithTag("Player").
            GetComponent<Health>();
        playerTransform = playerHealth.GetComponent<Transform>();

    }

    // Start is called before the first frame update
    void Start()
    {
        GameObject[] destinations = GameObject.FindGameObjectsWithTag("Dest");
        int pathIndex = Random.Range(0, destinations.Length);
        patrolDestination = destinations[Random.Range(0, destinations.Length)].GetComponent<Transform>();
        //  print($"Path: {pathIndex}");
        CurrentState = EMENY_STATE.PATROL;

    }

    public IEnumerator EnemyPatrol()
    {
        while (currentState == EMENY_STATE.PATROL)
        {
            checkMyVision.Sensitity = CheckMyVision.enmSensitity.HIGH;

            agent.isStopped = false;
            agent.SetDestination(patrolDestination.position);
            while (agent.pathPending)

                yield return null;

            if (checkMyVision.targetInSight)
            {
                agent.isStopped = true;
                CurrentState = EMENY_STATE.CHASE;
                yield break;
            }
            yield return null;
        }
    }
    public IEnumerator EnemyChase()
    {
        while (currentState == EMENY_STATE.CHASE)
        {
            checkMyVision.Sensitity = CheckMyVision.enmSensitity.LOW;
            agent.isStopped = false;
            agent.SetDestination(checkMyVision.lastKnownSighting);
            while (agent.pathPending)
            {
                yield return null;
            }
            if (agent.remainingDistance <= agent.stoppingDistance)
            {
                agent.isStopped = true;
                if (!checkMyVision.targetInSight)
                {
                    CurrentState = EMENY_STATE.PATROL;
                }
                else
                {
                    CurrentState = EMENY_STATE.ATTACK;

                }
                yield break;
            }
            yield return null;
        }
    }


    public IEnumerator EnemyAttack()
    {
        while (currentState == EMENY_STATE.ATTACK)
        {
            Debug.Log("Attacking!");
            agent.isStopped = false;
            agent.SetDestination(playerTransform.position);
            while (agent.pathPending)

                yield return null;

            if (agent.remainingDistance > agent.stoppingDistance)
            {
                CurrentState = EMENY_STATE.CHASE;
                yield break;
            }
            else
            {
                playerHealth.HealthPoints -= maxDemage * Time.deltaTime;
            }
            yield return null;
        }

        yield break;
    }*/
}



