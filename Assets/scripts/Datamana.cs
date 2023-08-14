using UnityEngine;

[CreateAssetMenu(menuName = "team/Data mana")]
public class Datamana : ScriptableObject
{
	[Header("魔力"), Range(1, 100)]
	public float mana = 100;
}
