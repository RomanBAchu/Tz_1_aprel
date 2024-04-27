using UnityEngine;

[CreateAssetMenu(fileName = "New item", menuName = "Inventory/Item")]

public class Item : ScriptableObject
{
    [Header("������� ��������������")]
    public string Name = " ";
    public string Description = "�������� ��������";
    public Sprite icon = null;
}
