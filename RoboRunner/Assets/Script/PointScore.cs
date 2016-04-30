using Project202;
using System;
using UnityEngine;

namespace AssemblyCSharp
{
    public class PointScore : ScoreObserver
    {
        public PointScore(ScoreSubject scoreSub)
        {
            this.scoreSubject = scoreSub;
            this.scoreSubject.Attach(this);
            currentScore = this.scoreSubject.getScore(); // setting current score
        }

        //adding score
        public override void AddScore(int score)
        {
            //adding score
            scoreSubject.setScore(currentScore + score);
            //Debug.Log ("point add method : " + scoreSubject.getScore ());
        }


        //updating currentscore for this observer
        public override void Update(int newScore)
        {
            currentScore = newScore;
            //currentScore = this.scoreSubject.getScore();
        }

    }
}

