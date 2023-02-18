using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JP
{
    public class Character : MonoBehaviour
    {
        CharacterMovement characterMovement;
        CharacterHealth characterHealth;

        // Start is called before the first frame update
        void Start()
        {
            characterMovement = GetComponent<CharacterMovement>();
            characterHealth = GetComponent<CharacterHealth>();
        }

        private void FixedUpdate()
        {
            if (characterHealth.IsHurt)
            {
                characterHealth.Hurt();
                characterMovement.HurtMove();
            }
            else
            {
                characterMovement.MoveCharacter();
            }
        }

        public void OnTakeDamage(CharacterHealth.DamageInfo damageInfo)
        {
            characterHealth.TakeDamage(damageInfo);
        }
    }
}
