using System;
using UnityEngine;
using UnityEngine.InputSystem;

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
        public enum ControllerState
        {
            Grounded,
            Sliding,
            Falling,
            Rising,
            Sprinting,
            Jumping
        }

        public static ThirdPersonController Instance;
        [Header("Third Person View Types")]
        [Tooltip("Choose third person view type")]
        public ThirdPersonTypes viewTypes;

        [Header("Component References")]
        [Tooltip("References to attached components")]
        private Transform _playerTransform;
        private Rigidbody _playerRigidbody;
        private Animator _playerAnimator;

        private void Awake()
        {
            _playerRigidbody = GetComponent<Rigidbody>();
            _playerAnimator = GetComponent<Animator>();
        }

        public void Jump(InputAction.CallbackContext context)
        {
            if (context.performed)
            {
                _playerRigidbody.AddForce(Vector3.up * 5f, ForceMode.Impulse);
            }
        }

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
