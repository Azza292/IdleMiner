﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Miner : WorkerBase {


    private Animator workerAnimator;


    protected override void Awake()
    {
        base.Awake();

        workerAnimator = gameObject.GetComponentInChildren<Animator>();
        CarryValueTextRenderer.enabled = false;
    }

    protected override void ReceiveOrders(WorkerStates nextDesiredState)
    {
        workerAnimator.Play("wait");
        base.ReceiveOrders(nextDesiredState);
    }

    protected override void Collect(WorkerStates nextDesiredState, Func<decimal, decimal> collectionMethod)
    {
        workerAnimator.Play("collect");

        // Collect an infinte amount of resources from the mine
        base.Collect(nextDesiredState, (x) => { return x; });
    }

    protected override void MoveToCollect(WorkerStates nextDesiredState)
    {
        workerAnimator.Play("roll");
        WorkerSprite.flipX = true;
        base.MoveToCollect(nextDesiredState);
    }

    protected override void MoveToDeposit(WorkerStates nextDesiredState)
    {
        workerAnimator.Play("roll");
        WorkerSprite.flipX = false;
        base.MoveToDeposit(nextDesiredState);
    }


}
