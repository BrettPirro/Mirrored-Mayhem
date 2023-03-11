using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GunTetris.Core 
{
    public class ScoreSave : MonoBehaviour
    {
        float SavedScore = 0;

        public void SetSaveScore(float Save) 
        {
            SavedScore = Save;
        }

        public float getSaveScore()
        {
            return SavedScore;
        }

    }
}
