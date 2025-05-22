using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public interface Interactable
{
    public string GetInteractPrompt();
    public void OnInteract();
}

public class ItemObject : MonoBehaviour, Interactable
{
    public ItemData data;

    public string GetInteractPrompt()
    {
        return $"{data.displayName}\n{data.description}";
    }

    public void OnInteract()
    {
        CharacterManager.Instance.Player.itemData = data;
        CharacterManager.Instance.Player.additem?.Invoke();
        Destroy(gameObject);
    }
}
