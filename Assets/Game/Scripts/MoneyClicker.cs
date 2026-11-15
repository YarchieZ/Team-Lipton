using UnityEngine;
using UnityEngine.UI;

public class MoneyClicker : MonoBehaviour
{
    [SerializeField] private ResourceManager resourceManager;
    [SerializeField] private int incomePerClick = 1;
    private Button button;

    private void Awake()
    {
        button = GetComponent<Button>();
    }

    private void OnEnable()
    {
        if (button != null)
        {
            button.onClick.AddListener(Clicker);
        }
    }

    private void Clicker()
    {
        resourceManager.ChangeMoney(incomePerClick);
    }

    public void ChangeIncome(int addedIncome)
    {
        incomePerClick += addedIncome;
    }

    private void OnDisable()
    {
        if (button != null)
        {
            button.onClick.RemoveListener(Clicker);
        }
    }
}
