using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckVision : MonoBehaviour
{
    public enum enmSensitity { HIGH, LOW };

    public enmSensitity Sensitity = enmSensitity.HIGH;
    public bool targetInSight = false;
    public float fieldOfVision = 45f;
    private Transform target = null;

    public Transform myEyes = null;

    public Transform npcTransform = null;

    private SphereCollider sphereCollider = null;

    public Vector3 lastKnownSighting = Vector3.zero;

    private void Awake()
    {
        npcTransform = GetComponent<Transform>();
        sphereCollider = GetComponent<SphereCollider>();
        lastKnownSighting = npcTransform.position;
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

    }

    bool InMyFieldOfVision()
    {
        Vector3 dirtoTarget = target.position - myEyes.position;
        float angle = Vector3.Angle(myEyes.forward, dirtoTarget);
        if (angle <= fieldOfVision)
        {
            return true;
        }
        else
        {
            return false;
        }

    }
    bool ClearLineOfSight()
    {
        RaycastHit hit;
        if (Physics.Raycast(myEyes.position, (target.position - myEyes.position).normalized,
            out hit, sphereCollider.radius))
        {
            if (hit.transform.CompareTag("Player"))
            {
                return true;
            }
        }
        return false;
    }
    void UpdateSight()
    {
        switch (Sensitity)
        {
            case enmSensitity.HIGH:
                targetInSight = InMyFieldOfVision() && ClearLineOfSight();
                break;
            case enmSensitity.LOW:
                targetInSight = InMyFieldOfVision() || ClearLineOfSight();
                break;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        UpdateSight();
        if (targetInSight)
        {
            lastKnownSighting = target.position;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (!other.CompareTag("Player"))
        {
            return;
        }
        targetInSight = false;
    }
}
