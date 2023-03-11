using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace GunTetris.Core 
{
    public class ScoreUpdateGO : MonoBehaviour
    {
        [SerializeField] Text ScoreText;

        void Start()
        {
            ScoreText.text = FindObjectOfType<ScoreSave>().getSaveScore().ToString();
        }


        
    }
}
