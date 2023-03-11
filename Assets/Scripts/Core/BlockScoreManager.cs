using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace GunTetris 
{
    public class BlockScoreManager : MonoBehaviour
    {
        [SerializeField] Text ScoreText;
        [SerializeField]float Score = 0;




        void Update()
        {
            ScoreText.text = Score.ToString();
        }

        public void AddScore(float Add)
        {
            Score += Add;
        }

        public void SubScore(float Sub)
        {
            Score -= Sub;
        }

        public float GetScore()
        {
            return Score;
        }

    }

}