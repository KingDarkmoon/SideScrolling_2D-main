using UnityEngine;

[CreateAssetMenu(menuName = "team/Data Health")]
public class DataHp : ScriptableObject
{
	[Header("血量")]
	public float hp = 100;
}
