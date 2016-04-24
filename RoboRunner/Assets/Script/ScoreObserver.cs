
using System;
using UnityEngine;
namespace Project202
{
	public abstract class ScoreObserver 
	{
		protected string observerState;
		protected int score = 0;

		protected int currentScore;

		public abstract void Update (int newScore);
		public abstract void AddScore(int newScore);

		/*public ScoreObserver (ScoreSubject scoreSubject)
		{
			this.scoreSubject = scoreSubject;
		}

		public void Update(){

		}

		public void ShowState(){
			Debug.Log ("Observer : " + observerState);
		}*/

	}
}

