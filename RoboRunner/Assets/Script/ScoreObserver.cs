using Project202;
using System;
using UnityEngine;
namespace AssemblyCSharp
{
	public abstract class ScoreObserver 
	{
		protected string observerState;
		protected int score = 0;

		protected int currentScore;

		public abstract void Update (int newScore);
		public abstract void AddScore(int newScore);


	}
}

