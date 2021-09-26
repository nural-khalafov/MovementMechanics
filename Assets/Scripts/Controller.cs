using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DZenEngine.Core.MovementMechanics
{
    public abstract class Controller : MonoBehaviour
    {
        public abstract Vector3 GetVelocity();
        public abstract Vector3 GetMovementVelocity();
        public abstract bool IsGrounded();

        public delegate void VectorEvent(Vector3 vector);

        public VectorEvent OnJump;
        public VectorEvent OnLand;
    }
}

