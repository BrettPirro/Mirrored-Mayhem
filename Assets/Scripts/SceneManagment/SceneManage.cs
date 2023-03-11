using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace GunTetris.SceneManaging 
{
    public class SceneManage : MonoBehaviour
    {
        bool load=false;


        public void LoadIntoGameOver() 
        {
            if (load == false) 
            {
                StartCoroutine(LoadGameOver());
              
            }
        }

        public void LoadIntoMenu()
        {
            if (load == false)
            {
                StartCoroutine(LoadMainMenu());
            }
        }
        public void LoadIntoNextLevel()
        {
            if (load == false)
            {
                StartCoroutine(LoadNextLevel());
            }
        }
       


        IEnumerator LoadGameOver() 
        {
            load = true;
            yield return FindObjectOfType<Fader>().FadeIn();
            yield return SceneManager.LoadSceneAsync("GameOver");
            yield return FindObjectOfType<Fader>().FadeOut();
            load = false;
        }

        IEnumerator LoadNextLevel()
        {
            load = true;
            yield return FindObjectOfType<Fader>().FadeIn();
            yield return SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex+1);
            yield return FindObjectOfType<Fader>().FadeOut();
            load = false;

        }

        IEnumerator LoadMainMenu()
        {
            load = true;
            yield return FindObjectOfType<Fader>().FadeIn();
            yield return SceneManager.LoadSceneAsync("MainMenu");
            yield return FindObjectOfType<Fader>().FadeOut();
            load = false;

        }

    }
}
