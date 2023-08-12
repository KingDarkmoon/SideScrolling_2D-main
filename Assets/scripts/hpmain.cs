using UnityEngine.UI;
using UnityEngine;

public class hpmain : MonoBehaviour
{
    [Header ("最大血量")]
    public int maxHealth = 100;

    [Header ("目前血量")]
    public int currentHealth;        // 目前血量

    public Slider healthSlider;      // 用於顯示血量的Slider

    public void Start()
    {
        currentHealth = maxHealth;   // 初始化血量為最大血量
        UpdateHealthUI();            // 更新血量UI
    }

    // 受到傷害
    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount; // 扣除傷害值
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth); // 確保血量不超過最大血量
        UpdateHealthUI();              // 更新血量UI

        if (currentHealth <= 0)
        {
            Die();                     // 如果血量歸零，執行角色死亡的相應處理
        }
    }

    // 恢復血量
    public void Heal(int healAmount)
    {
        currentHealth += healAmount;  // 增加恢復值
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth); // 確保血量不超過最大血量
        UpdateHealthUI();             // 更新血量UI
    }

    // 更新血量UI
    void UpdateHealthUI()
    {
        if (healthSlider != null)
        {
            healthSlider.value = (float)currentHealth / maxHealth;  // 更新Slider的值
        }
    }

    // 角色死亡
    void Die()
    {
        // 在這裡執行角色死亡的相應處理，例如遊戲結束或重生等
    }
}
