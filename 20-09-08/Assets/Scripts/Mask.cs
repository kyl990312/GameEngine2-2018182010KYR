using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Script
{
    public class Mask : MonoBehaviour
    {

        private Rigidbody2D _rigid;

        public float speed = 20.0f;
        // Start is called before the first frame update
        void Start()
        {
            _rigid = GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update()
        {
            var colliders = new Collider2D[5];
            Physics2D.OverlapCircleNonAlloc(new Vector2(transform.position.x, transform.position.y), 10f,colliders);
            
            var candidate = colliders.Where(col => col != null).Aggregate((col1,col2)=>
            {
                var mag1 = (col1.transform.position - transform.position).magnitude;
                var mag2 = (col2.transform.position - transform.position).magnitude;
                return mag1 < mag2 ? col1 : col2;
            });

            if (candidate != null)
                _rigid.AddForce((candidate.transform.position - transform.position).normalized * speed);
        }
        
    }
}

