using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GunTetris.Core 
{
    public class Blocks : MonoBehaviour
    {
        private enum ColorOfBlock { Red, Blue, Green, Yellow, Orange };
        [SerializeField]BoxCollider2D BlockCheck1, BlockCheck2, BlockCheck3, BlockCheck4;
        [SerializeField] ColorOfBlock color;
        bool Matched=false;
        float timer;
        bool hit;
        Animator animator;
        [SerializeField] AudioClip pop;


        

        private void Start()
        {
            timer = 0;
            animator = GetComponent<Animator>();
        }



        private void Update()
        {
            if (Matched) 
            {


               
                if (!hit)
                {
                    DestroyTheBlockStyle();
                    
                    FindObjectOfType<BlockScoreManager>().AddScore(100f);
                    hit = true;
                }

            }

            Check();


        }

        public void DestroyTheBlockStyle()
        {
            animator.SetTrigger("Destroy");
        }

        private void Check()
        {
            if (BlockCheck1.IsTouchingLayers(LayerMask.GetMask(color.ToString()))|| BlockCheck2.IsTouchingLayers(LayerMask.GetMask(color.ToString()))|| BlockCheck3.IsTouchingLayers(LayerMask.GetMask(color.ToString()))|| BlockCheck4.IsTouchingLayers(LayerMask.GetMask(color.ToString())))
            {
                TimerCheck();

            }
            else 
            {
                timer = 0;
            }
           
        }

        private void TimerCheck()
        {
            timer += Time.deltaTime;
            if (timer >= .4f) { Matched = true; }
        }

       
        public void DeleteBlock() 
        {
            Destroy(gameObject);
        }

        public void PlayPopSound() 
        {
            AudioSource.PlayClipAtPoint(pop, Camera.main.transform.position,.2f);
        }
       

    }

}