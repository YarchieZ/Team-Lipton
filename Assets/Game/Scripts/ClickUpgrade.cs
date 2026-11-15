using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ClickUpgrade : MonoBehaviour
{
    [Header("Ссылки на менеджеры")]
    [SerializeField] private ResourceManager resourceManager; // деньги
    [SerializeField] private MoneyClicker moneyClicker;       // кликер

    [Header("Настройки этой кнопки")]
    [SerializeField] private int cost = 10;                   // цена улучшения
    [SerializeField] private int addedIncome = 1;             // прибавка к клику
    [SerializeField] private TextMeshProUGUI costText;        // текст на самой кнопке

    private Button upgradeButton;

    private void Start()
    {
        upgradeButton = GetComponent<Button>();
        if (resourceManager == null)
            resourceManager = FindFirstObjectByType<ResourceManager>();

        if (moneyClicker == null)
            moneyClicker = FindFirstObjectByType<MoneyClicker>();

        UpdateCostText();

        if (upgradeButton != null)
        {
            upgradeButton.onClick.AddListener(BuyClickUpgrade);
        }
    }

    public void BuyClickUpgrade()
    {
        if (resourceManager.Money >= cost)
        {
            resourceManager.ChangeMoney(-cost);
            moneyClicker.ChangeIncome(addedIncome);
        }
    }

    private void UpdateCostText()
    {
        if (costText != null)
        {
            costText.text = $"Прокачка\n{cost}";
        }
    }

    private void OnDestroy()
    {
        if (upgradeButton != null)
        {
            upgradeButton.onClick.RemoveListener(BuyClickUpgrade);
        }
    }
}

