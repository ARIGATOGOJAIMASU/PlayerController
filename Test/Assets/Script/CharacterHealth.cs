using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JP
{
    public class CharacterHealth : MonoBehaviour
    {
        bool isHurt;
        bool isInvincible;

        [SerializeField] float InvincibleTime;

        DamageInfo takenDamageInfo;
        CharacterInformation characterInformation;
        Rigidbody characterRigdbody;

        public bool IsHurt { get { return isHurt; } }
        public bool IsInvincible { get { return isInvincible; } }

        public void Start()
        {
            characterInformation = GetComponent<CharacterInformation>();
        }

        public enum DamageType { powerful, weak }
        public struct DamageInfo
        {
            public float damageValue;
            public DamageType damageType;

            public DamageInfo(float damage, DamageType type = DamageType.weak)
            {
                damageValue = damage;
                damageType = type;
            }
        }

        public void TakeDamage(DamageInfo damageInfo)
        {
            if (isHurt || isInvincible) return;

            isHurt = true;
            takenDamageInfo = damageInfo;
        }

        public void Hurt()
        {
            isHurt = false;
            characterInformation.RunTimeHP -= takenDamageInfo.damageValue;
            StartCoroutine(Invincible());
        }

        IEnumerator Invincible()
        {
            isInvincible = true;
            yield return new WaitForSeconds(InvincibleTime);
            isInvincible = false;
        }
    }
}
