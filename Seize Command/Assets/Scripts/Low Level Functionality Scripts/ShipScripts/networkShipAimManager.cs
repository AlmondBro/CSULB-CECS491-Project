using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class networkShipAimManager : AbstractAimManager {

	[SyncVar] Quaternion syncShipRot;

	[SerializeField] Transform shipTransform;
    [SerializeField] float rotation_speed;

    public bool inSeat;
    void Start()
    {
        //enabled = false; 
        inSeat = false; 
    }
    void FixedUpdate()
    {   
        if(inSeat)
        {
        Aim();
        }

        if(isServer)
        {
        RpcUpdateRot();
        }
        else
        {
        CmdUpdateRot();
        }
    }

    protected override void Aim()
    {

         Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        difference.Normalize();
        float rotation_z = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        Quaternion rot = Quaternion.Euler(0f, 0f, rotation_z + -90);

        syncShipRot = Quaternion.RotateTowards(transform.rotation, rot, rotation_speed * Time.deltaTime);
    }

    [ClientRpc]
    public void RpcUpdateRot()
    {
        transform.rotation = syncShipRot;
    }

    [Command]
    public void CmdUpdateRot()
    {
        RpcUpdateRot();
    }
}
