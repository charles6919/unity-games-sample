using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace FlightShooter
{
    public enum BulletType
    {
        PlayerBullet = 0,
        EnemyBullet
    }
    
    /// <summary>
    /// Bullet에서는 기본적인 정보들을 정의해주는 역할을 해준다.
    /// 여러가지 Bullet종류가 있을수 있으니 해당 Bullet들은 이를 상속받아 추가적인 효과를 정의한다.
    /// </summary>
    public abstract class Bullet : MonoBehaviour
    {
        public BulletType type;
        public float speed;
        public int damage;
        public float timer = 0f;
        public float lifeTime = 5f;

        /// <summary>
        /// 이동 메서드
        /// </summary>
        protected abstract void Move();
        
        /// <summary>
        /// 충돌 메서드
        /// </summary>
        protected abstract void Collision();
        
        /// <summary>
        /// 데미지 전달 메서드
        /// </summary>
        /// <param name="target">해당 파라미터는 데미지를 받는 별도의 오브젝트 class로 대체한다.</param>
        protected abstract void ToDamage(Object target);

        /// <summary>
        /// Bullet을 파괴시키는 메서드
        /// </summary>
        protected abstract void Destroy();
    }
}
