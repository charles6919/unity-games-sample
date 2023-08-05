using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlightShooter
{
    public class Background : MonoBehaviour
    {
        public GameObject sky1;

        public float moveSpeed = 1f;
    
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            sky1.transform.position += Vector3.back * (moveSpeed * Time.deltaTime);

            if (sky1.transform.localPosition.z <= -160f)
            {
                sky1.transform.localPosition = new Vector3(0f, 0f, 160f);
            }
        }
        
        
    }
}

