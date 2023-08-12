using UnityEngine;

[CreateAssetMenu(menuName = "team/Data Health")]
public class DataHp : ScriptableObject
{
	[Header("¦å¶q"), Range(1, 100)]
	public float hp = 100;
}
