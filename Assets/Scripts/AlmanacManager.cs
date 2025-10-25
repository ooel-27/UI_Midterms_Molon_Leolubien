using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AlmanacManager : MonoBehaviour
{
    [Header("Card Setup")]
    public Transform contentParent;         
    public GameObject cardPrefab;        
    public CharacterData[] characters;      

    [Header("Detail Panel")]
    public GameObject detailPanel; 
    public Image detailPortrait;
    public TMP_Text detailName;
    public TMP_Text detailRole;
    public TMP_Text detailDescription;
    private void Start()
    {
        PopulateCards();
        if (detailPanel != null)
            detailPanel.SetActive(false);
    }

    private void PopulateCards()
    {
        if (cardPrefab == null || contentParent == null || characters == null)
            return;

        foreach (CharacterData data in characters)
        {
            GameObject cardObj = Instantiate(cardPrefab, contentParent);
            CharacterCardUI ui = cardObj.GetComponent<CharacterCardUI>();
            if (ui != null)
            {
                ui.Setup(data, this);
            }
        }
    }

    public void ShowCharacterDetail(CharacterData data)
    {
        if (detailPanel == null) return;

        detailPanel.SetActive(true);

        if (detailName != null)
            detailName.text = data.characterName;

        if (detailRole != null)
            detailRole.text = $"Role: {data.role}";

        if (detailDescription != null)
            detailDescription.text = data.description;

        if (detailPortrait != null)
            detailPortrait.sprite = data.characterImage;
    }

    public void CloseDetailPanel()
    {
        if (detailPanel != null)
            detailPanel.SetActive(false);
    }
}
