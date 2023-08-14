using UnityEngine;

public class DamageSystem : MonoBehaviour
{
    [Header("血量資料")]
    public DataHp data;

	private float hp;

	private void Awake()
	{
		hp = data.hp;
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if(collision.gameObject.name.Contains(""))
		{
			GetDamage();
		}
	}

	private void GetDamage()
	{
		data.hp -= 50;
		if (hp <= 0) Dead();
	}
	private void Dead()
	{
		Destroy(gameObject);
	}
}
