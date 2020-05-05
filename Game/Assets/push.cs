using NPOI.SS.Formula.Functions;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this script pushes all rigidbodies that the character touches
var pushPower = 2.0;
private object hit;

object Rigidbody { get; private set; }

private Function OnControllerColliderHit(hit : ControllerColliderHit)
{
    var body : Rigidbody = hit.collider.attachedRigidbody;
    // no rigidbody 
    if (body == null || body.isKinematic)
        return;

    // We dont want to push objects below us
    if (hit.moveDirection.y < -0.3)
        return;

    // Calculate push direction from move direction, 
    // we only push objects to the sides never up and down
    var pushDir = Vector3(hit.moveDirection.x, 0, hit.moveDirection.z);

    // If you know how fast your character is trying to move,
    // then you can also multiply the push velocity by that.

    // Apply the push
    body.velocity = pushDir * pushPower;
}