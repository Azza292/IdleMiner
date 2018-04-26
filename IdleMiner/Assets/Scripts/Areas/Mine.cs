﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine : WorkingAreaBase {

    [SerializeField]
    private Transform collectAreaTransform;

    protected override void Start()
    {
        CollectPosition = collectAreaTransform.position;
        MovementSpeed = 0.5f;
        CollectionSpeed = 20;
        CarryCapacity = 50;

        base.Start();
    }

}
