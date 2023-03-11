using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GunTetris.SceneManaging;

namespace GunTetris.Core 
{
    public class GameUI : MonoBehaviour
    {
        BlockScoreManager scoreManager;

        private void Start()
        {
            try 
            {
                scoreManager = FindObjectOfType<BlockScoreManager>();
            }
            catch 
            {
                Debug.Log("No ScoreManager in Scene");
            }
        }
        

        public void LoadMenu() 
        {
            FindObjectOfType<SceneManage>().LoadIntoMenu();
        }

        public void LoadNextLevel()
        {
            FindObjectOfType<SceneManage>().LoadIntoNextLevel();
        }



        public void DestroyAllBlock(float Required) 
        {
            if (Required > scoreManager.GetScore()) { return; }
            
                scoreManager.SubScore(Required);
                foreach(Blocks i in FindObjectsOfType<Blocks>()) 
                {
                    i.DestroyTheBlockStyle();
                    Debug.Log("Worked");
                }
            


        }
    }
}
