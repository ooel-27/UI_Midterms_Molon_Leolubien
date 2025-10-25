using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CharacterCardUI : MonoBehaviour
{
    public Image portraitImage;
    public TMP_Text nameText;

    private CharacterData characterData;
    private AlmanacManager manager;

    public void Setup(CharacterData data, AlmanacManager almanaManager)
    {
        characterData = data;
        manager = almanaManager;

        if (nameText != null) nameText.text = data.characterName;
        if (portraitImage != null) portraitImage.sprite = data.characterImage;

        Button btn = GetComponent<Button>();
        if (btn != null)
        {
            btn.onClick.RemoveAllListeners();
            btn.onClick.AddListener(OnCardClicked);
        }
    }

    private void OnCardClicked()
    {
        if (manager != null && characterData != null)
        {
            manager.ShowCharacterDetail(characterData);
        }
    }
}