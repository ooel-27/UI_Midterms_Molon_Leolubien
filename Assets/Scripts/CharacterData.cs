using UnityEngine;

[CreateAssetMenu(fileName = "CharacterData", menuName = "Almanac/Character")]
public class CharacterData : ScriptableObject
{
    public string characterName;
    public Sprite characterImage;
    public string role;  // ✅ Add this line
    [TextArea(2, 5)]
    public string description;
}