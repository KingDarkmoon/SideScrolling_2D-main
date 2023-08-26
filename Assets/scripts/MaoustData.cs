using UnityEngine;

[CreateAssetMenu(menuName = "team/Data Maoust")]
public class MaoustData : ScriptableObject
{
	[Header("血量"), Range(1, 100)]
	public float hp = 100;
}
