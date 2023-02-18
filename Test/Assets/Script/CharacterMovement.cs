using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JP
{
    public class CharacterMovement : MonoBehaviour
    {
        Rigidbody characterRigdbody;
        CharacterInformation characterInformation;
        Transform characterTransform;

        float horizontalInput;
        float verticalInput;
        Vector3 moveDirection;

        private void Start()
        {
            characterRigdbody = GetComponent<Rigidbody>();
            characterInformation = GetComponent<CharacterInformation>();
            characterTransform = GetComponent<Transform>();

            characterRigdbody.freezeRotation = true;
        }

        private void Update()
        {
            InputCheck();
        }

        private void InputCheck()
        {
            verticalInput = Input.GetAxisRaw("Vertical");
            horizontalInput = Input.GetAxisRaw("Horizontal");
        }

        public void MoveCharacter()
        {
            moveDirection = characterTransform.forward * verticalInput + characterTransform.right * horizontalInput;
            characterRigdbody.MovePosition(characterTransform.position + moveDirection * characterInformation.RunTimeAGI * Time.fixedDeltaTime);
        }

        public void HurtMove()
        {
            characterRigdbody.AddForce(characterTransform.up * 10f);
        }
    }
}
    