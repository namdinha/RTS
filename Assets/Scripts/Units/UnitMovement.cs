using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.AI;

public class UnitMovement : NetworkBehaviour {
    
    [SerializeField] private NavMeshAgent agent = null;

    #region Server

    [Command]
    public void CmdMove(Vector3 newPos) {
        if(!NavMesh.SamplePosition(newPos, out NavMeshHit hit, 1f, NavMesh.AllAreas)) { return; }
        agent.SetDestination(hit.position);
    }

    #endregion

}
