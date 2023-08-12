using UnityEngine;

[CreateAssetMenu(menuName = "team/Data Health")]
public class DataHp : ScriptableObject
{
	[Header("��q"), Range(1, 100)]
	public float hp = 100;
}
