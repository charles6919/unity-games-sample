using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlightShooter
{
    public class PlayerDefaultBullet : Bullet
    {
        // Start is called before the first frame update
        void Start()
        {
            type = BulletType.PlayerBullet;
            speed = 100f;
            damage = 10;
        }

        // Update is called once per frame
        private void Update()
        {
            timer += Time.deltaTime;
            if (timer >= lifeTime)
            {
                Destroy();
            }
            
            Move();
        }

        protected override void Move()
        {
            transform.Translate(Vector3.forward * (speed * Time.deltaTime));
        }

        protected override void Collision()
        {
            throw new System.NotImplementedException();
        }

        protected override void ToDamage(Object target)
        {
            throw new System.NotImplementedException();
        }

        protected override void Destroy()
        {
            Destroy(gameObject);
        }
    }
}

