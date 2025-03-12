using UnityEngine;

namespace Player
{
	[CreateAssetMenu(menuName="Player/New Player")]
	public class player_so : ScriptableObject
	{
	    public string playername;
	    public int player_Score;
	}
}