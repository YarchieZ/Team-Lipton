using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UpgraderManager : MonoBehaviour
{
    [SerializeField] private ResourceManager resourceManager; // скрипт с деньгами
    [SerializeField] private Button unlockButton;             // кнопка "Разблокировать"
    [SerializeField] private GameObject lockPanel;            // панелька разблокировки

    [SerializeField] private int cost;                        // цена для разблокировки
    [SerializeField] private TextMeshProUGUI costText;
    //[SerializeField] private int multiIncomeBonus;            // крат для прокачки апгрейдов: 1x, 10x, 50x и т.д.
    //[SerializeField] private int MFS;                         // деньги в секунду (для заводов)

    private void Start()
    {

        if (costText != null)
        {
            costText.text = $"Разблокировать:\n{cost}";
        }

        if (unlockButton != null)
        {
            unlockButton.onClick.AddListener(Unlock);
        }
    }

    public void Unlock()
    {
        if (resourceManager.Money >= cost)
        {
            resourceManager.ChangeMoney(-cost);
            if (lockPanel != null)
            {
                lockPanel.SetActive(false);
            }
        }
    }

    private void OnDestroy()
    {
        if (unlockButton != null)
        {
            unlockButton.onClick.RemoveListener(Unlock);
        }
    }
}

