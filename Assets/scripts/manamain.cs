using UnityEngine.UI;
using UnityEngine;

public class manamain : MonoBehaviour
{
    [Header ("魔力最大值"), Range(0,500)]
    public int maxMagic = 100;

    [Header ("目前魔力值")]
    public int currentMagic;

    [Header ("魔力恢復")]
    public float regenRate = 2f; // 魔力值恢復速率

    public Slider magicSlider; // 顯示魔力值的UI Slider

    private float regenTimer; // 魔力值恢復計時器

    private void Start()
    {
        currentMagic = maxMagic; // 初始化當前魔力值為最大魔力值
        UpdateMagicUI(); // 更新魔力值UI
    }

    private void Update()
    {
        if (currentMagic < maxMagic)
        {
            regenTimer += Time.deltaTime; // 開始計時

            if (regenTimer >= regenRate)
            {
                currentMagic++; // 增加魔力值
                regenTimer = 0f; // 重置計時器
                UpdateMagicUI(); // 更新魔力值UI
            }
        }
    }

    public void UseMagic(int amount)
    {
        if (currentMagic >= amount)
        {
            currentMagic -= amount; // 減少魔力值
            UpdateMagicUI(); // 更新魔力值UI
        }
        else
        {
            Debug.Log("Not enough magic!"); // 魔力值不足
        }
    }

    private void UpdateMagicUI()
    {
        magicSlider.value = (float)currentMagic / maxMagic; // 更新UI Slider的值
    }
}
