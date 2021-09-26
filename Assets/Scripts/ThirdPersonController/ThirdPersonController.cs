using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DZenEngine.Core.MovementMechanics
{
    [Serializable]
    public enum ThirdPersonTypes
    {
        Classic,
        SoulsLike,
        ShoulderView
    }

    public class ThirdPersonController : Controller
    {
        public static ThirdPersonController Instance;
        [Header("Third Person View Types")]
        [Tooltip("Choose third person view type")]
        public ThirdPersonTypes viewTypes;

        [Header("Component References")]
        [Tooltip("References to attached components")]
        public Transform PlayerTransform;


        public override Vector3 GetVelocity()
        {
            throw new NotImplementedException();
        }

        public override Vector3 GetMovementVelocity()
        {
            throw new NotImplementedException();
        }

        public override bool IsGrounded()
        {
            throw new NotImplementedException();
        }
    }
}
