using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlightShooter
{
    public abstract class Object : MonoBehaviour
    {
        public float moveSpeed = 1f;
        public float shootingSpeed = 1f;
        protected float shootTimer = 0f;
        
        public int hp;//현재체력
        public int maxHp;//최대체력
        
        /// <summary>
        /// 초기화 메서드
        /// </summary>
        protected abstract void Init();
        
        /// <summary>
        /// Hp가 0이되면 실행할 메서드
        /// </summary>
        public abstract void Destroy();
        
        /// <summary>
        /// Bullet을 발사하는 메서드
        /// </summary>
        public abstract void Shoot();
        
        /// <summary>
        /// 피격당했을때 실행할 메서드
        /// </summary>
        public abstract void Hit();
        
    }
}

