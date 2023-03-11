using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GunTetris.SceneManaging;

namespace GunTetris.Core 
{
    public class GameOverColider : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.tag == "Block")
            {
                FindObjectOfType<SceneManage>().LoadIntoGameOver();
                FindObjectOfType<ScoreSave>().SetSaveScore(FindObjectOfType<BlockScoreManager>().GetScore());
            }
        }

    }

}