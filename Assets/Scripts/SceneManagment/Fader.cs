using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GunTetris.SceneManaging
{
    public class Fader : MonoBehaviour
    {
        
        public IEnumerator FadeIn() 
        {
            GetComponent<Animator>().SetBool("Fade", true);
            yield return new WaitForSeconds(0.45f);

        }

        public IEnumerator FadeOut()
        {
            GetComponent<Animator>().SetBool("Fade", false);
            yield return new WaitForSeconds(0.45f);

        }


    }



}
