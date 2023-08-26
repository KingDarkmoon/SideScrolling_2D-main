using UnityEngine;
using UnityEngine.UI;

public class PlayerSystem : MonoBehaviour
{
	[Header("玩家血量")]
	public DataHp HPdata;
	public Image hpimg;

	[Header("玩家魔力")]
	public Datamana MAData;


	private void OnCollisionEnter2D(Collision2D collision)
	{
		if(collision.gameObject.name.Contains("M_S"))
		{
			GetDamage();
		}
	}
	private void GetDamage()
	{
		 HPdata.hp -= 50;
	}
}
