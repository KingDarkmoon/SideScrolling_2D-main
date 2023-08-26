using UnityEngine;
using UnityEngine.UI;

public class PlayerSystem : MonoBehaviour
{
	[Header("玩家血量")]
	public DataHp HPdata;
	public Image hpimg;

	[Header("玩家魔力")]
	public Datamana MAData;

	private float hp = 100;
	private float hpMax = 100;

	private void Start()
	{
		HPdata.hp = hp;
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if(collision.gameObject.name.Contains("M_S"))
		{
			HPdata.hp -= 50;
			/*print("碰到怪物了");*/
			hpimg.fillAmount = hp / hpMax;
		}
	}

	private void Update()
	{
		if(HPdata.hp == 0)
		{
			GetDie();
		}
	}
	private void GetDie()
	{
		Destroy(gameObject);
	}
}
