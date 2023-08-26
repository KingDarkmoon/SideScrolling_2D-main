using UnityEngine;
using UnityEngine.UI;

public class PlayerSystem : MonoBehaviour
{
	[Header("玩家血量")]
	public DataHp HPdata;
	public Image hpimg;

	[Header("玩家魔力")]
	public Datamana MAData;

	private float hp;
	private float hpMax;

	private void Start()
	{
		HPdata.hp = 100;
		hp = HPdata.hp;
		hpMax = hp;
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if(collision.gameObject.name.Contains("M_S"))
		{
			GetDamage();
		}
	}

	private void GetDamage()
	{
		HPdata.hp -= 10;
		/*print("碰到怪物了");*/
		hpimg.fillAmount = hp / hpMax;
	}

	private void Update()
	{
		if(hp == 0)
		{
			GetDie();
		}
	}
	private void GetDie()
	{
		Destroy(gameObject);
		Debug.Log("你已死亡");
	}
}
