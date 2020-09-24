using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagdollTriggerBehavior : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        RagdollBehavior ragdoll = collision.transform.GetComponentInParent<RagdollBehavior>();
        if (ragdoll != null)
            ragdoll.ragdollEnabled = true;
    }
}
