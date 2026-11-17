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
        if (resourceManager.GetResource(ResourceType.Money) >= cost)
        {
            resourceManager.AddResource(ResourceType.Money, -cost);
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

