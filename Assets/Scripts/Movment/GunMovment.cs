using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GunTetris.Movment 
{
    public class GunMovment : MonoBehaviour
    {
        Rigidbody2D Myrigidbody2D;
        Vector2 MovmentUpdate;
        [SerializeField] float MovmentSpacing = 1.5f;
        bool Moved = false;
        [SerializeField] float movmentDelay = 0.1f;

        void Start()
        {
            Myrigidbody2D = GetComponent<Rigidbody2D>();
            MovmentUpdate = transform.position;
        }

        private void FixedUpdate()
        {


            if (Input.GetAxis("Horizontal") != 0 && !Moved)
            {
                StartCoroutine(Move());
            }

        }

        void Update()
        {

        }

        IEnumerator Move()
        {
            Moved = true;
            Vector2 LastPos = MovmentUpdate;
            MovmentUpdate.x += Input.GetAxisRaw("Horizontal")* MovmentSpacing;
            if(MovmentUpdate.x>4.5f|| MovmentUpdate.x < -4.5f) 
            {
                MovmentUpdate = LastPos;

            }
            Myrigidbody2D.MovePosition(MovmentUpdate);
          
            
            
            
            yield return new WaitForSeconds(movmentDelay);
           

            Moved = false;

        }



    }

}
