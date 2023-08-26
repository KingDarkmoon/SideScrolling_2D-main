using UnityEngine;

[CreateAssetMenu(menuName = "team/Data Health")]
public class DataHp : ScriptableObject
{
	[Header("血量"), Range(1, 100)]
	public float hp = 100;

}
