using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;


namespace FlightShooter
{
    public class PlayerPlane : Object
    {
        

        public GameObject bulletPrefab;
        public Transform bulletCollector;
        private Vector3 firePos = new Vector3();
        

        /// <summary>
        /// 지정한 방향으로 개체를 이동시킴
        /// </summary>
        /// <param name="direction"></param>
        public void Move(Vector3 direction)
        {
            transform.localPosition += direction * (moveSpeed * Time.deltaTime);
        }


        protected override void Init()
        {
            shootTimer = shootingSpeed;
        }

        public override void Destroy()
        {
            throw new System.NotImplementedException();
        }
        
        
        public override void Shoot()
        {
            var bullet = Instantiate(bulletPrefab, gameObject.transform.position + firePos, Quaternion.identity, bulletCollector);
        }
        
        
        public override void Hit()
        {
            throw new System.NotImplementedException();
        }

        private void MoveControl()
        {
            var vertical = Input.GetAxis("Vertical");
            var horizontal = Input.GetAxis("Horizontal");

            Move(new Vector3(horizontal, 0f, vertical));
        }

        private void Start()
        {
            Init();
        }

        private void Update()
        {
            MoveControl();
            shootTimer += Time.deltaTime * shootingSpeed;
            if (Input.GetKey(KeyCode.Space) && shootTimer >= 1f)
            {
                shootTimer = 0f;
                Shoot();
            }
        }
    }
}

