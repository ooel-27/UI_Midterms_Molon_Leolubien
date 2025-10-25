using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AlmanacUI : MonoBehaviour
{
    [Header("UI References")]
    [SerializeField] private GameObject detailPanel;
    [SerializeField] private TextMeshProUGUI nameText;
    [SerializeField] private Image portrait;
    [SerializeField] private TextMeshProUGUI roleText;
    [SerializeField] private TextMeshProUGUI descriptionText;

    public void ShowCharacterData(CharacterData data)
    {
        if (data == null)
        {
            Debug.LogError("No CharacterData provided to AlmanacUI.");
            return;
        }

        detailPanel.SetActive(true);

        if (nameText != null)
            nameText.text = data.characterName;

        if (portrait != null)
            portrait.sprite = data.characterImage;

        if (roleText != null)
            roleText.text = $"Role: {data.role}";

        if (descriptionText != null)
            descriptionText.text = data.description;
    }

    public void CloseDetail()
    {
        if (detailPanel != null)
            detailPanel.SetActive(false);
    }
}
