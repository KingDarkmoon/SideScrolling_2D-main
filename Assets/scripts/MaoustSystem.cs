using UnityEngine;

public class MaoustSystem : MonoBehaviour
{
	[Header("血量資料")]
	public MaoustData Data;

	[Header("怪物動畫")]
	public Animator animer;

	[Header("攻擊範圍")]
	public float attackRange = 10.0f;

	[Header("攻擊冷卻")]
	public float attackCooldown = 0.5f;

	private float nextAttackTime = 0.0f;
	public Transform player;

	private void Update()
	{
		float distanceToPlayer = Vector2.Distance(transform.position, player.position);

		// 如果玩家靠近且攻击冷却时间已过，进行攻击
		if (distanceToPlayer <= attackRange && Time.time >= nextAttackTime)
		{
			Attack();
			nextAttackTime = Time.time + attackCooldown;
		}
	}
	private void Attack()
	{
		animer.SetTrigger("attack"); //觸發攻擊動畫
	}
}
