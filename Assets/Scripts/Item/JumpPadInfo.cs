using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class JumpPadInfo : MonoBehaviour, Interactable
{
    public string displayName = "���� �е�";
    public string description = "������ �ϴ÷� �����ؿ�!";

    public string GetInteractPrompt()
    {
        return $"{displayName}\n{description}";
    }

    public void OnInteract()
    {
    }
}