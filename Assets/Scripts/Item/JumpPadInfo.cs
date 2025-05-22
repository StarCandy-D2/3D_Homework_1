using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class JumpPadInfo : MonoBehaviour, Interactable
{
    public string displayName = "점프 패드";
    public string description = "밟으면 하늘로 점프해요!";

    public string GetInteractPrompt()
    {
        return $"{displayName}\n{description}";
    }

    public void OnInteract()
    {
    }
}