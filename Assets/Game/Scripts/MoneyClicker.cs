using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MoneyClicker : MonoBehaviour
{
    [SerializeField] private ResourceManager resourceManager;
    [SerializeField] private Image image;
    [SerializeField] private int incomePerClick;
    [SerializeField] private float fillPerClick;
    private Button button;
    private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(Clicker);

    }

    private void Clicker()
    {
        if (image.fillAmount >= 1)
        {
            image.fillAmount = 0;
            resourceManager.ChangeMoney(incomePerClick);
        }
        else
        {
            image.fillAmount += fillPerClick;
            
        }
    }

    private void OnDisable()
    {
        button.onClick.RemoveAllListeners();
    }
}
